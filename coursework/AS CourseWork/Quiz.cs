using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Resources;
using System.ComponentModel;
using System.Drawing;

namespace AS_CourseWork
{
    class Quiz
    {
        private static string currentTopic, currentDifficulty;

        private Quiz()
        {

        }

        public static string CurrentTopic { get => currentTopic; set => currentTopic = value; }
        public static string CurrentDifficulty { get => currentDifficulty; set => currentDifficulty = value; }

        public static List<MultipleChoice> GetMCQs()
        {
            List<MultipleChoice> question = new List<MultipleChoice>();
            List<MultipleChoice> randomisedQuestions = new List<MultipleChoice>();


            string path = "MultipleChoiceQuestions.csv";
            string[] questions = new string[File.ReadAllLines(path).Length];
            int questionNo = questions.Length;
            questions = File.ReadAllLines(path);

            string[] temp = new string[8];

            for (int i = 0; i < questionNo; i++)
            {
                temp = questions[i].Split(',');
               
                    MultipleChoice n = new MultipleChoice();
                    if (temp[6] == currentTopic)
                    {
                        n.QuestionText = temp[0];
                        n.possibleAns[0] = temp[1];
                        n.possibleAns[1] = temp[2];
                        n.possibleAns[2] = temp[3];
                        n.possibleAns[3] = temp[4];
                        n.Answer = temp[5];
                        question.Add(n);
                    }
            }

            while (randomisedQuestions.Count < question.Count)
            {
                Random r = new Random();
                int randomInt = r.Next(0, question.Count);
                while (randomisedQuestions.Contains(question[randomInt]))
                {
                    randomInt = r.Next(0, question.Count);
                }
                randomisedQuestions.Add(question[randomInt]);
            }
            
            return randomisedQuestions;
        }

        public static List<DnD> GetDnDs()
        {
            List<DnD> questions = new List<DnD>();
            List<DnD> randomisedQuestions = new List<DnD>();
            ResourceManager rm = Resources.Resources.ResourceManager;

            string path = "DragAndDropQuestions.csv";
            string[] lines = File.ReadAllLines(path);
            string[] Qs = new string[File.ReadAllLines(path).Length];
            int questionNo = Qs.Length;


            foreach (string line in lines)
            {

                string[] question = line.Split(',');

                DnD d = new DnD();
                if (currentTopic == question[7])
                {
                    d.QuestionText = question[0];
                    d.Text[0] = question[1];
                    d.Text[1] = question[2];
                    d.Text[2] = question[3];
                    d.Image[0] = (Image)rm.GetObject(question[4]);
                    d.Image[1] = (Image)rm.GetObject(question[5]);
                    d.Image[2] = (Image)rm.GetObject(question[6]);
                    questions.Add(d);
                }


                

            }

            while (randomisedQuestions.Count < questions.Count)
            {
                Random r = new Random();
                int randomInt = r.Next(0, questions.Count);
                while (randomisedQuestions.Contains(questions[randomInt]))
                {
                    randomInt = r.Next(0, questions.Count);
                }
                randomisedQuestions.Add(questions[randomInt]);
            }

            return randomisedQuestions;
            
        }
    }
}
