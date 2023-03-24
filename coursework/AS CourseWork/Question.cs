using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_CourseWork
{
    class Question
    {
        private string questionText, topic, difficulty;

        public string QuestionText { get => questionText; set => questionText = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
    }
}
