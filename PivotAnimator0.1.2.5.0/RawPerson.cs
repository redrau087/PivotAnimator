using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PivotAnimator0._1._2._5
{
    public class RawPerson
    {
        private Point head;
        private Point neck;
        private Point chest;
        private Point pelvis;

        private Point leftElbow;
        private Point leftHand;
        private Point rightElbow;
        private Point rightHand;

        private Point leftKnee;
        private Point leftFoot;
        private Point rightKnee;
        private Point rightFoot;

        public Point Head
        {
            get
            {
                return head;
            }
        }
        public Point Neck
        {
            get
            {
                return neck;
            }
        }
        public Point Chest
        {
            get
            {
                return chest;
            }
        }
        public Point Pelvis
        {
            get
            {
                return pelvis;
            }
        }
        public Point LeftElbow
        {
            get
            {
                return leftElbow;
            }
        }
        public Point LeftHand
        {
            get
            {
                return leftHand;
            }
        }
        public Point RightElbow
        {
            get
            {
                return rightElbow;
            }
        }
        public Point RightHand
        {
            get
            {
                return rightHand;
            }
        }
        public Point LeftKnee
        {
            get
            {
                return leftKnee;
            }
        }
        public Point LeftFoot
        {
            get
            {
                return leftFoot;
            }
        }
        public Point RightKnee
        {
            get
            {
                return rightKnee;
            }
        }
        public Point RightFoot
        {
            get
            {
                return rightFoot;
            }
        }

        public RawPerson(Point headIn, Point neckIn, Point chestIn, 
            Point pelvisIn, Point leftElbowIn, Point leftHandIn, 
            Point rightElbowIn, Point rightHandIn, Point leftKneeIn, 
            Point leftFootIn, Point rightKneeIn, Point rightFootIn)
        {
            head = headIn;
            neck = neckIn;
            chest = chestIn;
            pelvis = pelvisIn;
            leftElbow = leftElbowIn;
            leftHand = leftHandIn;
            rightElbow = rightElbowIn;
            rightHand = rightHandIn;
            leftKnee = leftKneeIn;
            leftFoot = leftFootIn;
            rightKnee = rightKneeIn;
            rightFoot = rightFootIn;
        }

        public RawPerson(string fileChunk)
        {
            ProcessFileData(fileChunk);
        }

        private void ProcessFileData(string fileData)
        {
            string[] points = fileData.Split(' ');
            List<string[]> coordinatesString = new List<string[]>();

            int[,] coordinates = new int[12, 2];


            for (int x = 0; x < points.Length; x++)
            {
                if (points[x] != "")
                    coordinatesString.Add(points[x].Split(','));
            }

            for (int x = 0; x < coordinatesString.Count; x++)
            {
                coordinates[x, 0] = Convert.ToInt32(coordinatesString[x][0]);
                coordinates[x, 1] = Convert.ToInt32(coordinatesString[x][1]);
            }

            head = new Point(coordinates[0, 0], coordinates[0, 1]);
            neck = new Point(coordinates[1, 0], coordinates[1, 1]);
            chest = new Point(coordinates[2, 0], coordinates[2, 1]);
            pelvis = new Point(coordinates[3, 0], coordinates[3, 1]);
            leftElbow = new Point(coordinates[4, 0], coordinates[4, 1]);
            leftHand = new Point(coordinates[5, 0], coordinates[5, 1]);
            rightElbow = new Point(coordinates[6, 0], coordinates[6, 1]);
            rightHand = new Point(coordinates[7, 0], coordinates[7, 1]);
            leftKnee = new Point(coordinates[8, 0], coordinates[8, 1]);
            leftFoot = new Point(coordinates[9, 0], coordinates[9, 1]);
            rightKnee = new Point(coordinates[10, 0], coordinates[10, 1]);
            rightFoot = new Point(coordinates[11, 0], coordinates[11, 1]);
        }
        public override string ToString()
        {
            string data = $"N {head.X},{head.Y} ";
            data += $"{neck.X},{neck.Y} {chest.X},{chest.Y} {pelvis.X},{pelvis.Y} ";
            data += $"{leftElbow.X},{leftElbow.Y} {leftHand.X},{leftHand.Y} ";
            data += $"{rightElbow.X},{rightElbow.Y} {rightHand.X},{rightHand.Y} ";
            data += $"{leftKnee.X},{leftKnee.Y} {leftFoot.X},{leftFoot.Y} ";
            data += $"{rightKnee.X},{rightKnee.Y} {rightFoot.X},{rightFoot.Y} ";

            return data;
        }
    }
}
