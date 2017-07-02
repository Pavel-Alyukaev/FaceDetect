using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Face;

namespace FaceDetect
{
    public partial class Form1 : Form
    {
        #region
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Павел\Documents\DBFaces.mdf;Integrated Security=True;Connect Timeout=30");

        private VideoCapture camVideo = null;
        private Image<Bgr, byte> testImage, originalImage;
        Image<Gray, byte>[] detectFace;
        int[] detectFaceLabels;
        List<Rectangle> faces;
        int curentFace = -1;

        //Haar Parameters
        public static int windowsSize = 20;
        public static Double scaleIncreaseRate = 1.1;
        public static int minNeighbors = 10;
        CascadeClassifier haar = new CascadeClassifier(@"haarcascade_frontalface_default.xml");

        //Eigen v
        int eigenTrainedImageCounter;
        List<Image<Gray, byte>> eigenTrainingImages = new List<Image<Gray, byte>>();
        List<int> eigenIntlabels = new List<int>();
        List<string> eigenlabels = new List<string>();
        EigenFaceRecognizer eigenFaceRecognizer;
        List<string> nameFaces=new List<string>();

        #endregion


        public Form1()
        {
            InitializeComponent();
            //TreinEingen();
        }

        private void MoveVideo(object sender, EventArgs e)
        {
            originalImage = camVideo.QueryFrame().ToImage<Bgr, byte>().Resize(400, 300, Inter.Area);
            testImage = originalImage.Clone();
            if (rbAvtoSerch.Checked) AvtoSerch();
            if (rbAvtoRecognaze.Checked)
            {
                FaceEigenRecognaze();
                for (int CurentFace = 0; CurentFace < faces.Count - 1; CurentFace++)
                {
                    int X = faces.ElementAt<Rectangle>(CurentFace).X;
                    int Y = faces.ElementAt<Rectangle>(CurentFace).Y;
                    CvInvoke.PutText(
                            testImage,
                            nameFaces.ElementAt<string>(CurentFace),
                            new System.Drawing.Point(X, Y),
                            FontFace.HersheyComplex,
                            1.0,
                            new Bgr(0, 255, 0).MCvScalar);
                }
                imageBox1.Image = testImage;
            }
            else
                imageBox1.Image = testImage;
        }

        private void LoadFoto()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Cursor Files|*.jpg",
                Title = "Select a JPG File"
            };
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                originalImage = new Image<Bgr, byte>(openFileDialog1.FileName).Resize(400, 300, Inter.Area);
                testImage = originalImage.Clone();
                if (rbAvtoSerch.Checked) AvtoSerch();
                imageBox1.Image = testImage;
            }
        }

        private void Detect()
        {
            faces = new List<Rectangle>();
            Image<Gray, byte> grayframe = testImage.Convert<Gray, byte>();
            Rectangle[] facesDetected = haar.DetectMultiScale(
                   grayframe,
                   scaleIncreaseRate,
                   minNeighbors,
                   new Size(windowsSize, windowsSize));
            faces.AddRange(facesDetected);
        }

        private void SelectAllFaces()
        {
            Image<Gray, byte> imageFace = testImage.Clone().Convert<Gray, byte>();
            Detect();
            detectFace = new Image<Gray, byte>[faces.Count];
            detectFaceLabels = new int[faces.Count];
            int i = 0;
            foreach (Rectangle face in faces)
            {
                imageFace.ROI = face;
                detectFace[i] = imageFace.Clone().Resize(200, 200, Inter.Area);
                detectFaceLabels[i] = i++;
                CvInvoke.Rectangle(testImage, face, new Bgr(Color.Red).MCvScalar, 2);
            }
            curentFace = (faces.Count != 0) ? 0 : -1;
        }

        private void SelectFace()
        {
            Image<Bgr, byte> imageFace = testImage.Clone();
            if (faces.Count > 0)
            {
                imageBox2.Image = detectFace[curentFace];
                CvInvoke.Rectangle(testImage, faces.ElementAt<Rectangle>(curentFace),
                    new Bgr(Color.Green).MCvScalar, 2);
            }
        }

        private void AvtoSerch()
        {
            if (originalImage != null)
            {
                testImage = originalImage.Clone();
                SelectAllFaces();
                SelectFace();
            }
        }

















        private void FaceEigenRecognaze()
        {
            Image<Bgr, byte> imageFace = originalImage.Clone();
            int n = detectFace.Length;
            string nF;


            for (int CurentFace = 0; CurentFace < n; CurentFace++)
            {

                CvInvoke.cvResetImageROI(detectFace[CurentFace]);
                var result = eigenFaceRecognizer.Predict(detectFace[CurentFace]);
                label2.Text = result.Label.ToString();
                label3.Text = result.Distance.ToString();
                if (result.Label != -1)
                {
                    nF = eigenlabels[result.Label].ToString();// nameFaces.Add(eigenlabels[result.Label].ToString());
                }
                else
                {
                    nF = "0";// nameFaces.Add("0");
                }
                    int X = faces.ElementAt<Rectangle>(CurentFace).X;
                    int Y = faces.ElementAt<Rectangle>(CurentFace).Y;
                    CvInvoke.PutText(
                            imageFace,
                            nF,//nameFaces.ElementAt<string>(CurentFace),
                            new System.Drawing.Point(X, Y),
                            FontFace.HersheyComplex,
                            1.0,
                            new Bgr(0, 255, 0).MCvScalar);
                    imageBox1.Image = imageFace;
                    //label2.Text = eigenlabels[result.Label].ToString();

                

            }

        }



        private void TreinEingen()
        {
            string dataDirectory = Directory.GetCurrentDirectory() + "\\TrainedFaces";
            try
            {
                string[] files = Directory.GetFiles(dataDirectory, "*.jpg", SearchOption.AllDirectories);
                eigenTrainedImageCounter = 0;
                foreach (var file in files)
                {
                    Image<Bgr, Byte> TrainedImage = new Image<Bgr, Byte>(file);
                    //TrainedImage._EqualizeHist();
                    eigenTrainingImages.Add(TrainedImage.Convert<Gray, Byte>());
                    eigenlabels.Add(FileName(file));
                    eigenIntlabels.Add(eigenTrainedImageCounter);
                    eigenTrainedImageCounter++;
                    textBox2.Text += FileName(file) + "\r\n";
                }
                eigenFaceRecognizer = new EigenFaceRecognizer(eigenTrainedImageCounter, 2000);
                eigenFaceRecognizer.Train(eigenTrainingImages.ToArray(), eigenIntlabels.ToArray());
            }
            catch (Exception )
            {
                MessageBox.Show("Nothing in binary database, " +
                    "please add at least a face(Simply train the prototype with the Add Face Button).",
                    "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        string FileName(string file)
        {
            string[] fileArr = file.Split('\\');
            var fileName = fileArr[fileArr.Length - 1].Split('_')[0];
            return fileName;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (rbFoto.Checked)
            {
                if (camVideo != null)
                {
                    camVideo.Stop();
                    Application.Idle -= MoveVideo;
                    camVideo = null;
                }
                LoadFoto();
            }
            else if (rbVideo.Checked)
            {
                if (camVideo == null)
                {
                    faces = new List<Rectangle>();
                    camVideo = new VideoCapture();
                    Application.Idle += MoveVideo;
                }
            }
        }

        private void BtnSerchFace_Click(object sender, EventArgs e)
        {
            AvtoSerch();
        }

        private void BtnTrein_Click(object sender, EventArgs e)
        {
            try
            {
                string dataDirectory = Directory.GetCurrentDirectory() + "\\TrainedFaces";
                string[] files = Directory.GetFiles(dataDirectory, "*.jpg", SearchOption.AllDirectories);
                eigenTrainedImageCounter = 0;
                foreach (var file in files)
                {
                    Image<Bgr, Byte> TrainedImage = new Image<Bgr, Byte>(file);
                    TrainedImage._EqualizeHist();
                    eigenTrainingImages.Add(TrainedImage.Convert<Gray, Byte>());
                    eigenlabels.Add(FileName(file));
                    eigenIntlabels.Add(eigenTrainedImageCounter);
                    eigenTrainedImageCounter++;
                    textBox2.Text += FileName(file) + "\r\n";
                }
                eigenFaceRecognizer = new EigenFaceRecognizer(eigenTrainedImageCounter, 1000);
                eigenFaceRecognizer.Train(eigenTrainingImages.ToArray(), eigenIntlabels.ToArray());
                //eigenFaceRecognizer.Save(dataDirectory + "\\trainedDataEigen.dat");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnNextFace_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> imageFace = originalImage.Clone();
            if (curentFace < detectFace.Length - 1)
            {
                curentFace++;
                
                imageBox2.Image = detectFace[curentFace];
                foreach (Rectangle face in faces)
                    CvInvoke.Rectangle(imageFace, face, new Bgr(Color.Red).MCvScalar, 2);
                CvInvoke.Rectangle(imageFace, faces.ElementAt(curentFace), new Bgr(Color.Green).MCvScalar, 2);
                imageBox1.Image = imageFace;
            }
            else
            {
                MessageBox.Show("Достигнут конец выборки");
            }
        }

        private void BtnPrewFace_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> imageFace = testImage.Clone();
            if (curentFace > 0)
            {
                curentFace--;
                imageBox2.Image = detectFace[curentFace];
                foreach (Rectangle face in faces)
                    CvInvoke.Rectangle(imageFace, face, new Bgr(Color.Red).MCvScalar, 2);
                CvInvoke.Rectangle(imageFace, faces.ElementAt(curentFace), new Bgr(Color.Green).MCvScalar, 2);
                imageBox1.Image = imageFace;
            }
            else
            {
                MessageBox.Show("Достигнут конец выборки");
            }

        }

        private void BtnAddBase_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text + "_" + DateTime.Now.Day.ToString() + "-"
            + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString()
            + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
            + "-" + DateTime.Now.Second.ToString() + ".jpg";

            Directory.CreateDirectory("TrainedFaces");
             detectFace[curentFace].Convert<Gray, byte>().ToBitmap().Save("TrainedFaces\\" + fileName);

        }

        private void BtnRecognaze_Click(object sender, EventArgs e)
        {
            FaceEigenRecognaze();
        }

        private void RbManualSerch_CheckedChanged(object sender, EventArgs e)
        {
            btnSerchFace.Enabled = true;
        }

        private void RbAvtoTrein_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbAvtoSerch_CheckedChanged(object sender, EventArgs e)
        {
            btnSerchFace.Enabled = false;
        }
    }
}