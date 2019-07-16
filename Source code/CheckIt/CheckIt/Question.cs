using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIt
{
    public class Question
    {
        public string topicId { get; set; }
        public string questionId { get; set; }
        public string questionDesc { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
        //public string corectionAnswer { get; set; }
        public string optionAStatus { get; set; }
        public string optionBStatus { get; set; }
        public string optionCStatus { get; set; }
        public string optionDStatus { get; set; }
        public string questionCode { get; set; }
    }

}
