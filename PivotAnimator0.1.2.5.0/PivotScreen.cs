using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PivotAnimator0._1._2._5._0
{
    public partial class PivotScreen : Form
    {
        private float headCircleStart = (float)(14 * Math.Sqrt(2));
        private float circleStart = (float)(3 * Math.Sqrt(2)) / 2;
        private Person person;
        private RawPerson[] animation;
        private OpenFileDialog openFileDialog;
        private int currentFrame;
        public PivotScreen()
        {
            currentFrame = 0;
            animation = new RawPerson[0];
            person = new Person();
            InitializeComponent();
            animationTimer.Enabled = false;
            this.MouseClick += MouseClickMethod;
            this.Paint += DrawPerson;
        }

        private void MouseClickMethod(object sender, MouseEventArgs e)
        {
            person.ClickBodyPart(e.X, e.Y);
            if (person.Selected != SelectedPart.None)
                this.MouseMove += MouseMovedMethod;
            else
                this.MouseMove -= MouseMovedMethod;
        }

        private void MouseMovedMethod(object sender, MouseEventArgs e)
        {
            person.MoveBodyPart(e.X, e.Y);
            this.Invalidate();
        }

        private void DrawPerson(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (animation.Length > 0)
            {
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].Neck, animation[animation.Length - 1].Pelvis);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].Neck, animation[animation.Length - 1].LeftElbow);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].LeftElbow, animation[animation.Length - 1].LeftHand);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].Neck, animation[animation.Length - 1].RightElbow);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].RightElbow, animation[animation.Length - 1].RightHand);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].Pelvis, animation[animation.Length - 1].LeftKnee);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].LeftKnee, animation[animation.Length - 1].LeftFoot);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].Pelvis, animation[animation.Length - 1].RightKnee);
                g.DrawLine(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].RightKnee, animation[animation.Length - 1].RightFoot);
                g.DrawEllipse(new Pen(Brushes.Gray, 7), animation[animation.Length - 1].Head.X - headCircleStart, animation[animation.Length - 1].Head.Y - headCircleStart, 40, 40);

            }

            g.DrawLine(new Pen(Brushes.Black, 7), person.Neck, person.Pelvis);
            g.DrawLine(new Pen(Brushes.Black, 7), person.Neck, person.LeftElbow);
            g.DrawLine(new Pen(Brushes.Black, 7), person.LeftElbow, person.LeftHand);
            g.DrawLine(new Pen(Brushes.Black, 7), person.Neck, person.RightElbow);
            g.DrawLine(new Pen(Brushes.Black, 7), person.RightElbow, person.RightHand);
            g.DrawLine(new Pen(Brushes.Black, 7), person.Pelvis, person.LeftKnee);
            g.DrawLine(new Pen(Brushes.Black, 7), person.LeftKnee, person.LeftFoot);
            g.DrawLine(new Pen(Brushes.Black, 7), person.Pelvis, person.RightKnee);
            g.DrawLine(new Pen(Brushes.Black, 7), person.RightKnee, person.RightFoot);
            g.DrawEllipse(new Pen(Brushes.Black, 7), person.Head.X - headCircleStart, person.Head.Y - headCircleStart, 40, 40);

            g.FillEllipse(Brushes.Red, person.Head.X - circleStart, person.Head.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.Neck.X - circleStart, person.Neck.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.Chest.X - circleStart, person.Chest.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.Pelvis.X - circleStart, person.Pelvis.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.LeftElbow.X - circleStart, person.LeftElbow.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.LeftHand.X - circleStart, person.LeftHand.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.RightElbow.X - circleStart, person.RightElbow.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.RightHand.X - circleStart, person.RightHand.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.LeftKnee.X - circleStart, person.LeftKnee.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.LeftFoot.X - circleStart, person.LeftFoot.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.RightKnee.X - circleStart, person.RightKnee.Y - circleStart, 5, 5);
            g.FillEllipse(Brushes.Red, person.RightFoot.X - circleStart, person.RightFoot.Y - circleStart, 5, 5);


            g.Dispose();
        }

        private void fileMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Save Animation":
                    SaveCurrentState();
                    break;
                case "Add Scene":
                    AddNewScene();
                    break;
                case "Run Animation":
                    RunAnimation();
                    break;
                case "Stop Animation":
                    RunAnimation();
                    break;
                case "Open Animation":
                    OpenAnimation();
                    break;
                case "Open Background Image":
                    //OPEN FILE EXPLORER TO SELECT FILE AND SET FORM BACKGROUND TO IMAGE
                    OpenBackgroundImage();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            currentFrame += 1;
            if (currentFrame >= animation.Length)
            {
                RunAnimation();
                currentFrame = 0;
            }
        }

        private void SaveCurrentState()
        {
            saveFileDialog.ShowDialog();

            string fileWritePath = saveFileDialog.FileName;
            string fileData = "";

            if (fileWritePath != "")
            {
                for (int x = 0; x < animation.Length; x++)
                {
                    fileData += animation[x];
                }
                File.WriteAllText(fileWritePath, fileData);
            }
        }

        private void AddNewScene()
        {
            RawPerson[] oldArray = animation;
            RawPerson rawPerson = new RawPerson(person.Head, person.Neck, person.Chest,
                person.Pelvis, person.LeftElbow, person.LeftHand, person.RightElbow, person.RightHand,
                person.LeftKnee, person.LeftFoot, person.RightKnee, person.RightFoot);
            animation = new RawPerson[oldArray.Length + 1];

            for (int x = 0; x < oldArray.Length; x++)
            {
                animation[x] = oldArray[x];
            }
            animation[oldArray.Length] = rawPerson;
            this.Invalidate();
        }

        private void RunAnimation()
        {
            animationTimer.Enabled = !animationTimer.Enabled;
            if (animationTimer.Enabled)
            {
                optionsMenuStrip.Items[3].Text = "Stop Animation";
                this.Paint -= DrawPerson;
                this.Paint += DrawScene;
            }
            else
            {
                optionsMenuStrip.Items[3].Text = "Run Animation";
                currentFrame = 0;
                this.Paint += DrawPerson;
                this.Paint -= DrawScene;
                this.Invalidate();
            }
        }

        private void OpenAnimation()
        {
            openFileDialog.ShowDialog();

            string fileReadPath = openFileDialog.FileName;
            string fileData = "";

            if (File.Exists(fileReadPath))
            {
                fileData = File.ReadAllText(fileReadPath);

                string[] scenes = fileData.Split('N');
                animation = new RawPerson[scenes.Length];
                for (int x = 0; x < scenes.Length; x++)
                {
                    if (scenes[x] != "")
                        animation[x] = new RawPerson(scenes[x]);
                }
            }

            openFileDialog.FileName = "";
        }

        private void DrawScene(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].Head, animation[currentFrame].Neck);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].Neck, animation[currentFrame].Pelvis);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].Neck, animation[currentFrame].LeftElbow);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].LeftElbow, animation[currentFrame].LeftHand);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].Neck, animation[currentFrame].RightElbow);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].RightElbow, animation[currentFrame].RightHand);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].Pelvis, animation[currentFrame].LeftKnee);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].LeftKnee, animation[currentFrame].LeftFoot);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].Pelvis, animation[currentFrame].RightKnee);
            g.DrawLine(new Pen(Brushes.Black, 7), animation[currentFrame].RightKnee, animation[currentFrame].RightFoot);
            g.DrawEllipse(new Pen(Brushes.Black, 7), animation[currentFrame].Head.X - headCircleStart, animation[currentFrame].Head.Y - headCircleStart, 40, 40);

            g.Dispose();

        }

        private void OpenBackgroundImage()
        {
            openFileDialog.DefaultExt = "png";
            openFileDialog.ShowDialog();

            string filePath = openFileDialog.FileName;

            if (File.Exists(filePath))
            {
                this.BackgroundImage = Image.FromFile(filePath);
            }

            openFileDialog.DefaultExt = "pivot";
        }

        private void fpsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fpsTextBox.Text != "FPS" && IsNumber(fpsTextBox.Text))
            {
                animationTimer.Interval = 1000 / Convert.ToInt32(fpsTextBox.Text);
            }
        }

        private bool IsNumber(string text)
        {
            uint numberTest;
            bool valid = false;

            try
            {
                numberTest = Convert.ToUInt32(text);
                valid = true;
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }
}
