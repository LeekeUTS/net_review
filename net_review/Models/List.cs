using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace net_review.Models
{
    public class List
    {
        public int ID { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        public String QuestionCn { get; set; }
        public String AnswerCn { get; set; }
        public String AnswerSimple { get; set; }
        public String AnswerDraft { get; set; }
        public String Category { get; set; }
        public int Sort { get; set; }
        public int Num { get; set; }
        public Boolean Complete { get; set; }
        public Boolean Mark { get; set; }
        public int Cid { get; set; }
        public String Image { get; set; }
        public String Status { get; set; }
        public String Img { get; set; }
        public String ChoiceA { get; set; }
        public String ChoiceB { get; set; }
        public String ChoiceC { get; set; }
        public String ChoiceD { get; set; }
        public String ChoiceType { get; set; }
        public String ChoiceAnswer { get; set; }
    }
}