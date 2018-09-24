using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotAnimator0._1._2._5
{
    public enum SelectedPart
    {
        None,
        Head,
        Neck,
        Chest,
        Pelvis,
        LeftElbow,
        LeftHand,
        RightElbow,
        RightHand,
        LeftKnee,
        LeftFoot,
        RightKnee,
        RightFoot
    };
    public class Person
    {
        private double distanceHeadNeck;
        private double distanceNeckChest;
        private double distanceChestPelvis;

        private double distanceNeckLeftElbow;
        private double distanceLeftElbowLeftHand;
        private double distanceNeckRightElbow;
        private double distanceRightElbowRightHand;

        private double distancePelvisLeftKnee;
        private double distanceLeftKneeLeftFoot;
        private double distancePelvisRightKnee;
        private double distanceRightKneeRightFoot;


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

        private SelectedPart selected;


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
        public SelectedPart Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
            }
        }


        public Person()
        {
            selected = SelectedPart.None;
            SetupBodyPositions();
            SetupBodyDistances();
        }
        private void SetupBodyPositions()
        {
            head = new Point(300, 120);
            neck = new Point(300, 140);
            chest = new Point(300, 170);
            pelvis = new Point(300, 200);

            leftElbow = new Point(275, 150);
            leftHand = new Point(250, 175);
            rightElbow = new Point(325, 150);
            rightHand = new Point(350, 175);

            leftKnee = new Point(280, 225);
            leftFoot = new Point(275, 250);
            rightKnee = new Point(320, 225);
            rightFoot = new Point(325, 250);
        }
        private void SetupBodyDistances()
        {
            distanceHeadNeck = 20;
            distanceNeckChest = 30;
            distanceChestPelvis = 30;

            distanceNeckLeftElbow = CalculateDistance(300, 140, 275, 150);
            distanceLeftElbowLeftHand = CalculateDistance(275, 150, 250, 175);
            distanceNeckRightElbow = CalculateDistance(300, 140, 325, 150);
            distanceRightElbowRightHand = CalculateDistance(325, 150, 350, 175);
            distancePelvisLeftKnee = CalculateDistance(300, 200, 280, 225);
            distanceLeftKneeLeftFoot = CalculateDistance(280, 225, 275, 250);
            distancePelvisRightKnee = CalculateDistance(300, 200, 320, 225);
            distanceRightKneeRightFoot = CalculateDistance(320, 225, 325, 250);
        }
        public void ClickBodyPart(int mouseXIn, int mouseYIn)
        {
            if (selected != SelectedPart.None)
                selected = SelectedPart.None;
            else
            {
                double[] distances = new double[12];

                distances[0] = (CalculateDistance(head.X, head.Y, mouseXIn, mouseYIn));
                distances[1] = (CalculateDistance(neck.X, neck.Y, mouseXIn, mouseYIn));
                distances[2] = (CalculateDistance(chest.X, chest.Y, mouseXIn, mouseYIn));
                distances[3] = (CalculateDistance(pelvis.X, pelvis.Y, mouseXIn, mouseYIn));
                distances[4] = (CalculateDistance(leftElbow.X, leftElbow.Y, mouseXIn, mouseYIn));
                distances[5] = (CalculateDistance(leftHand.X, leftHand.Y, mouseXIn, mouseYIn));
                distances[6] = (CalculateDistance(rightElbow.X, rightElbow.Y, mouseXIn, mouseYIn));
                distances[7] = (CalculateDistance(rightHand.X, rightHand.Y, mouseXIn, mouseYIn));
                distances[8] = (CalculateDistance(leftKnee.X, leftKnee.Y, mouseXIn, mouseYIn));
                distances[9] = (CalculateDistance(leftFoot.X, leftFoot.Y, mouseXIn, mouseYIn));
                distances[10] = (CalculateDistance(rightKnee.X, rightKnee.Y, mouseXIn, mouseYIn));
                distances[11] = (CalculateDistance(rightFoot.X, rightFoot.Y, mouseXIn, mouseYIn));

                int index = FindLowestDistanceIndex(distances);

                if (distances[index] < 10)
                {
                    switch (index)
                    {
                        case 0:
                            selected = SelectedPart.Head;
                            break;
                        case 1:
                            selected = SelectedPart.Neck;
                            break;
                        case 2:
                            selected = SelectedPart.Chest;
                            break;
                        case 3:
                            selected = SelectedPart.Pelvis;
                            break;
                        case 4:
                            selected = SelectedPart.LeftElbow;
                            break;
                        case 5:
                            selected = SelectedPart.LeftHand;
                            break;
                        case 6:
                            selected = SelectedPart.RightElbow;
                            break;
                        case 7:
                            selected = SelectedPart.RightHand;
                            break;
                        case 8:
                            selected = SelectedPart.LeftKnee;
                            break;
                        case 9:
                            selected = SelectedPart.LeftFoot;
                            break;
                        case 10:
                            selected = SelectedPart.RightKnee;
                            break;
                        case 11:
                            selected = SelectedPart.RightFoot;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private Point MoveSelectedBodyPart(double angleIn, Point root, double partLength)
        {
            Point newPoint = new Point(0, 0);

            newPoint.X += (int)(root.X + (partLength * Math.Cos(angleIn)));
            newPoint.Y += (int)(root.Y + (partLength * Math.Sin(angleIn)));

            return newPoint;
        }

        private void MoveEntireBody(Point point)
        {
            Point mostLeft = FindMostLeftBodyPart();

            int changeX = point.X - pelvis.X;
            int changeY = point.Y - pelvis.Y;

            if (mostLeft.X + changeX > 150)
            {
                head.X += changeX;
                head.Y += changeY;

                neck.X += changeX;
                neck.Y += changeY;

                chest.X += changeX;
                chest.Y += changeY;

                pelvis.X += changeX;
                pelvis.Y += changeY;

                leftElbow.X += changeX;
                leftElbow.Y += changeY;

                leftHand.X += changeX;
                leftHand.Y += changeY;

                rightElbow.X += changeX;
                rightElbow.Y += changeY;

                rightHand.X += changeX;
                rightHand.Y += changeY;

                leftKnee.X += changeX;
                leftKnee.Y += changeY;

                leftFoot.X += changeX;
                leftFoot.Y += changeY;

                rightKnee.X += changeX;
                rightKnee.Y += changeY;

                rightFoot.X += changeX;
                rightFoot.Y += changeY;
            }
        }

        public void MoveBodyPart(int xIn, int yIn)
        {
            Point newPoint = new Point(0, 0);

            double angleDifference = 0;

            //CURRENTLY INCOMPLETE METHOD
            switch (selected)
            {
                case SelectedPart.Head:
                    head = MoveSelectedBodyPart(CalculateAngle(neck, new Point(xIn, yIn)), neck, distanceHeadNeck);
                    break;
                case SelectedPart.Neck:
                    //ROTATE ENTIRE UPPER BODY AROUND PIVOT POINT OF CHEST
                    break;
                case SelectedPart.Chest:
                    //ROTATE ENTIRE UPPER BODY AROUND PIVOT POINT OF PELVIS
                    break;
                case SelectedPart.Pelvis:
                    MoveEntireBody(new Point(xIn, yIn));
                    break;
                case SelectedPart.LeftElbow:
                    angleDifference = CalculateAngle(leftElbow, leftHand) - CalculateAngle(neck, leftElbow);

                    newPoint = MoveSelectedBodyPart(CalculateAngle(neck, new Point(xIn, yIn)), neck, distanceNeckLeftElbow);
                    if (newPoint.X > 150)
                    {
                        leftElbow = newPoint;

                        //ALSO MOVE LEFT HAND

                        leftHand = MoveSelectedBodyPart(CalculateAngle(neck, leftElbow) + angleDifference, leftElbow, distanceLeftElbowLeftHand);
                    }
                    break;
                case SelectedPart.LeftHand:
                    newPoint = MoveSelectedBodyPart(CalculateAngle(leftElbow, new Point(xIn, yIn)), leftElbow, distanceLeftElbowLeftHand);
                    if (newPoint.X > 150)
                        leftHand = newPoint;
                    break;
                case SelectedPart.RightElbow:
                    angleDifference = CalculateAngle(rightElbow, rightHand) - CalculateAngle(neck, rightElbow);

                    newPoint = MoveSelectedBodyPart(CalculateAngle(neck, new Point(xIn, yIn)), neck, distanceNeckRightElbow);
                    if (newPoint.X > 150)
                    {
                        rightElbow = newPoint;

                        //ALSO MOVE RIGHT HAND

                        rightHand = MoveSelectedBodyPart(CalculateAngle(neck, rightElbow) + angleDifference, rightElbow, distanceRightElbowRightHand);
                    }
                    break;
                case SelectedPart.RightHand:
                    newPoint = MoveSelectedBodyPart(CalculateAngle(rightElbow, new Point(xIn, yIn)), rightElbow, distanceRightElbowRightHand);
                    if (newPoint.X > 150)
                        rightHand = newPoint;
                    break;
                case SelectedPart.LeftKnee:
                    angleDifference = CalculateAngle(leftKnee, leftFoot) - CalculateAngle(pelvis, leftKnee);

                    newPoint = MoveSelectedBodyPart(CalculateAngle(pelvis, new Point(xIn, yIn)), pelvis, distancePelvisLeftKnee);
                    if (newPoint.X > 150)
                    {
                        leftKnee = newPoint;

                        //ALSO MOVE LEFT FOOT

                        leftFoot = MoveSelectedBodyPart(CalculateAngle(pelvis, leftKnee) + angleDifference, leftKnee, distanceLeftKneeLeftFoot);
                    }
                    break;
                case SelectedPart.LeftFoot:
                    newPoint = MoveSelectedBodyPart(CalculateAngle(leftKnee, new Point(xIn, yIn)), leftKnee, distanceLeftKneeLeftFoot);
                    if (newPoint.X > 150)
                        leftFoot = newPoint;
                    break;
                case SelectedPart.RightKnee:
                    angleDifference = CalculateAngle(rightKnee, rightFoot) - CalculateAngle(pelvis, rightKnee);

                    newPoint = MoveSelectedBodyPart(CalculateAngle(pelvis, new Point(xIn, yIn)), pelvis, distancePelvisRightKnee);
                    if (newPoint.X > 150)
                    {
                        rightKnee = newPoint;

                        //ALSO MOVE RIGHT FOOT

                        rightFoot = MoveSelectedBodyPart(CalculateAngle(pelvis, rightKnee) + angleDifference, rightKnee, distanceRightKneeRightFoot);
                    }
                    break;
                case SelectedPart.RightFoot:
                    newPoint = MoveSelectedBodyPart(CalculateAngle(rightKnee, new Point(xIn, yIn)), rightKnee, distanceRightKneeRightFoot);
                    if (newPoint.X > 150)
                        rightFoot = newPoint;
                    break;
                case SelectedPart.None:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public static double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            double distance = 0;
            distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
            return distance;
        }
        public static int FindLowestDistanceIndex(double[] distancesIn)
        {
            double smallestValue = distancesIn[0];
            int index = 0;
            for (int x = 0; x < 12; x++)
            {
                if (distancesIn[x] < smallestValue)
                {
                    smallestValue = distancesIn[x];
                    index = x;
                }
            }
            return index;
        }
        public static double CalculateAngle(Point point1, Point point2)
        {
            //ANGLE IS POINT 1 GOING TO POINT 2

            int differenceX = point2.X - point1.X;
            int differenceY = point2.Y - point1.Y;

            double angle = Math.Atan2(differenceY, differenceX);

            angle /= Math.PI / 180;

            //CONVERT TO DEGREES

            if (differenceX > 0)
            {
                if (differenceY < 0)
                {
                    angle += 360;
                }
            }
            else if (differenceX < 0)
            {
                if (differenceY < 0)
                {
                    angle += 360;
                }
            }
            else
            {
                if (differenceY > 0)
                {
                    angle = 90;
                }
                else if (differenceY < 0)
                {
                    angle = 270;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            angle *= Math.PI / 180;

            //CONVERT BACK TO RADIANS

            return angle;
        }
        public static double AbsoluteValue(double number)
        {
            if (number < 0)
                number *= -1;
            return number;
        }

        public static int FindLowestValueIndex(int[] values)
        {
            int smallestValue = values[0];
            int index = 0;
            for (int x = 0; x < 12; x++)
            {
                if (values[x] < smallestValue)
                {
                    smallestValue = values[x];
                    index = x;
                }
            }
            return index;
        }

        private Point FindMostLeftBodyPart()
        {
            int[] locations = new int[12];

            locations[0] = head.X;
            locations[1] = neck.X;
            locations[2] = chest.X;
            locations[3] = pelvis.X;
            locations[4] = leftElbow.X;
            locations[5] = leftHand.X;
            locations[6] = rightElbow.X;
            locations[7] = rightHand.X;
            locations[8] = leftKnee.X;
            locations[9] = leftFoot.X;
            locations[10] = rightKnee.X;
            locations[11] = rightFoot.X;

            int index = FindLowestValueIndex(locations);

            Point left = new Point(0, 0);

            switch (index)
            {
                case 0:
                    left = head;
                    break;
                case 1:
                    left = neck;
                    break;
                case 2:
                    left = chest;
                    break;
                case 3:
                    left = pelvis;
                    break;
                case 4:
                    left = leftElbow;
                    break;
                case 5:
                    left = leftHand;
                    break;
                case 6:
                    left = rightElbow;
                    break;
                case 7:
                    left = rightHand;
                    break;
                case 8:
                    left = leftKnee;
                    break;
                case 9:
                    left = leftFoot;
                    break;
                case 10:
                    left = rightKnee;
                    break;
                case 11:
                    left = rightFoot;
                    break;
                default:
                    throw new NotImplementedException();
            }
            return left;
        }
    }
}
