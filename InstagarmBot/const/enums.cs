using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstagarmBot
{
    public enum MediaType
    {
        [Display(Name = "عکس")]
        Picture,
        [Display(Name = "فیلم")]
        Video
    }

    public enum TraceBy
    {
        [Display(Name = "هشتگ")]
        Hashtag,
        [Display(Name = "مکان")]
        Location,
        [Display(Name = "پیج هدف")]
        Username
    }


    public enum FollowFrom
    {
        [Display(Name = "فالوورها")]
        followers,
        [Display(Name = "فالوینگ ها")]
        following,
    }

    public enum ActionType
    {
        [Display(Name = "لایک کامنت فالو خودکار")]
        Start_trace,
        [Display(Name = "لایک پست های فالووینگ های خودم")]
        like_My_Following,
        [Display(Name = "آنفالو")]
        unfollow,
        [Display(Name = "فالوو")]
        follow,
    }
}
