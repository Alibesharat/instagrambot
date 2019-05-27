using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// مدل ها برای نگاشت پارامترهای ورودی از Api
/// </summary>
namespace InstagarmBot.Models
{
    /// <summary>
    /// لاگین ، لایک ، کامنت ، فالو 
    /// </summary>
   public class Trace:BaseModel
    {
       
        public TraceBy traceBy { get; set; }
        public string parameter { get; set; }
        public int count { get; set; }
        public string CommentList { get; set; }

    }

    /// <summary>
    /// ثبت نام
    /// </summary>
    public class Register : BaseModel
    {
        public string emailorphone { get; set; }
        public string fullname { get; set; }
       
    }

    /// <summary>
    /// فالو 
    /// </summary>
    public class Follow :BaseModel
    {
        //آدرس صفحه
        public string parameter { get; set; }
        public FollowFrom followFrom { get; set; }
        public int count { get; set; }
    }

    /// <summary>
    /// آنفالو 
    /// </summary>
    public class UnFollow :BaseModel
    {
       
        public int count { get; set; }
    }


    public  class StatuseModel
    {
        public bool IsStarted { get; set; }

        public ActionType actionType { get; set; }
    }
}
