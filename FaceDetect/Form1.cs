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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Павел\Documents\DBFaces.mdf;Integrated Security=True;Connect Timeout=30");

        private VideoCapture CamVideo = null;
        private Image<Bgr, byte> TestImage;
        Image<Gray, byte>[] DetectFace;
        int[] DetectFaceLabels;
        List<Rectangle> faces; 

        int CurentFace =-1;
        public static int WindowsSize = 20;
        public static Double ScaleIncreaseRate = 1.1;
        public static int MinNeighbors = 10;
        CascadeClassifier haar = new CascadeClassifier(@"haarcascade_frontalface_default.xml");
        

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void MoveVideo(object sender, EventArgs e)
        {
            TestImage = CamVideo.QueryFrame().ToImage<Bgr, byte>().Resize(400,300,Inter.Area);
            Detect();
            foreach(Rectangle face in faces)
                CvInvoke.Rectangle(TestImage, face, new Bgr(Color.Red).MCvScalar, 2);
            imageBox1.Image = TestImage;
            faces.Clear();
        }



        public void Detect()
        {// Находим лица
            Image<Gray, byte> grayframe = TestImage.Convert<Gray, byte>();
            Rectangle[] facesDetected = haar.DetectMultiScale(
                   grayframe,
                   ScaleIncreaseRate,
                   MinNeighbors,
                   new Size(WindowsSize, WindowsSize));
            faces.AddRange(facesDetected);
        }


        //Eigen Parameters
        int eigenTrainedImageCounter;
        List<Image<Gray, byte>> eigenTrainingImages = new List<Image<Gray, byte>>();
        List<int> eigenIntlabels = new List<int>();
        List<string> eigenlabels = new List<string>();
        EigenFaceRecognizer eigenFaceRecognizer;

        string FileName(string file)
        {
            string[] fileArr = file.Split('\\');
            var fileName = fileArr[fileArr.Length - 1].Split('_')[0];
            return fileName;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //Загружаем JPG файл
                if (CamVideo != null)
                {
                    CamVideo.Stop();
                    Application.Idle -= MoveVideo;
                    CamVideo = null;
                }
                OpenFileDialog openFileDialog1 = new OpenFileDialog()
                {
                    Filter = "Cursor Files|*.jpg",
                    Title = "Select a JPG File"
                };
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TestImage = new Image<Bgr, byte>(openFileDialog1.FileName).Resize(400, 300, Inter.Area);
                    imageBox1.Image = TestImage;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (CamVideo == null)
                {
                    faces = new List<Rectangle>();
                    CamVideo = new VideoCapture();
                    Application.Idle += MoveVideo;
                }
            }
        }

        private void BtnSerchFace_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> imageFace = TestImage.Clone().Convert<Gray, byte>();
            faces = new List<Rectangle>();
            Detect();
            DetectFace = new Image<Gray, byte>[faces.Count];// = new Image<Bgr, byte>(200, 200);
            DetectFaceLabels = new int[faces.Count];
            int i = 0;
            foreach (Rectangle face in faces)
            {
                imageFace.ROI = face;
                DetectFace[i] = imageFace.Clone().Resize(200, 200, Inter.Area);
                DetectFaceLabels[i] = i++;
            }
            Image<Bgr, byte> imageFace1 = TestImage.Clone();
            if (faces.Count > 0)
            {
                CurentFace = 0;
                imageBox2.Image = DetectFace[CurentFace];
                CvInvoke.Rectangle(imageFace1, faces.ElementAt<Rectangle>(CurentFace), new Bgr(Color.Red).MCvScalar, 2);
            }
            else
            {
                CurentFace = -1;
            }
            imageBox1.Image = imageFace1;

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
                    Image<Bgr , Byte> TrainedImage = new Image<Bgr, Byte>(file);
                    TrainedImage._EqualizeHist();
                    eigenTrainingImages.Add(TrainedImage.Convert<Gray, Byte>());
                    eigenlabels.Add(FileName(file));
                    eigenIntlabels.Add(eigenTrainedImageCounter);
                    eigenTrainedImageCounter++;
                    textBox2.Text += FileName(file) + "\r\n";
                }
                eigenFaceRecognizer = new EigenFaceRecognizer(eigenTrainedImageCounter, 5);
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
            Image<Bgr, byte> imageFace = TestImage.Clone();
            if (CurentFace < DetectFace.Length - 1)
            {
                CurentFace++;
                imageBox2.Image = DetectFace[CurentFace];
                CvInvoke.Rectangle(imageFace, faces.ElementAt(CurentFace), new Bgr(Color.Red).MCvScalar, 2);
                imageBox1.Image = imageFace;
            }
            else
            {
                MessageBox.Show("Достигнут конец выборки");
            }

        }

        private void BtnPrewFace_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> imageFace = TestImage.Clone();
            if (CurentFace > 0)
            {
                CurentFace--;
                imageBox2.Image = DetectFace[CurentFace];
                CvInvoke.Rectangle(imageFace, faces.ElementAt<Rectangle>(CurentFace), new Bgr(Color.Red).MCvScalar, 2);
                int X = faces.ElementAt<Rectangle>(CurentFace).X;
                int Y = faces.ElementAt<Rectangle>(CurentFace).Y;
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
            DetectFace[CurentFace].Convert<Gray, byte>().ToBitmap().Save("TrainedFaces\\" + fileName);

        }

        private void BtnRecognaze_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> imageFace = TestImage.Clone();
            int n = DetectFace.Length;
            label2.Text = n.ToString();
            CvInvoke.cvResetImageROI(DetectFace[0]);
            //DetectFace[0]._EqualizeHist();

            var result = eigenFaceRecognizer.Predict(DetectFace[0]);
            for (int CurentFace = 0; CurentFace < n; CurentFace++)
            {

                label2.Text = result.Label.ToString();
                if (result.Label != -1)
                {
                    int X = faces.ElementAt<Rectangle>(CurentFace).X;
                    int Y = faces.ElementAt<Rectangle>(CurentFace).Y;
                    CvInvoke.PutText(
                            imageFace,
                            eigenlabels[result.Label].ToString(),
                            new System.Drawing.Point(X, Y),
                            FontFace.HersheyComplex,
                            1.0,
                            new Bgr(0, 255, 0).MCvScalar);
                    imageBox1.Image = imageFace;
                    label2.Text = eigenlabels[result.Label].ToString();
                }

            }


        }

        //private void trening()
        //{
        //    FaceRecognizer im = new EigenFaceRecognizer(1, 10);
        //    im.Train<Bgr, byte>(DetectFace, DetectFaceLabels);
        //    im.Predict()
        //}
    }


}
