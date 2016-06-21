﻿using System.ComponentModel;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The operator to use for querying segments
    /// Please visit http://developer.mailchimp.com/documentation/mailchimp/reference/lists/segments to view which options can be used with which fields
    /// </summary>
    public enum Operator
    {
        [Description("open")]
        Open,
        [Description("click")]
        Click,
        [Description("sent")]
        Sent,
        [Description("noopen")]
        NotOpened,
        [Description("noclick")]
        NotClicked,
        [Description("nosent")]
        NotSent,
        [Description("started")]
        Started,
        [Description("completed")]
        Completed,
        [Description("not_started")]
        NotStarted,
        [Description("not_completed")]
        NotCompleted,
        [Description("member")]
        Member,
        [Description("not_member")]
        NonMember,
        [Description("greater")]
        Greater,
        [Description("less")]
        Less,
        [Description("is")]
        Is,
        [Description("not")]
        Not,
        [Description("blank")]
        Blank,
        [Description("blank_not")]
        NotBlank,
        [Description("contains")]
        Contains,
        [Description("notcontains")]
        DoesNotContain,
        [Description("starts")]
        Starts,
        [Description("ends")]
        Ends,
        [Description("client_is")]
        ClientIs,
        [Description("client_not")]
        ClientIsNot,
        [Description("source_is")]
        SourceIs,
        [Description("source_not")]
        SourceIsNot,
        [Description("goal_not")]
        GoalNot,
        [Description("goal_notcontain")]
        GoalDoesNotContain,
        [Description("fuzzy_is")]
        FuzzyIs,
        [Description("fuzzy_not")]
        FuzzyIsNot,
        [Description("static_is")]
        StaticIs,
        [Description("static_not")]
        StatisIsNot,
        [Description("ipgeocountry")]
        IPGeoCountry,
        [Description("ipgeonotcountry")]
        IPGeoNotCountry,
        [Description("ipgeostate")]
        IPGeoState,
        [Description("ipgeonotstate")]
        IPGeoNotState,
        [Description("ipgeoin")]
        IPGeoIn,
        [Description("ipgeonotin")]
        IPGeoNotIn,
        [Description("ipgeoinzip")]
        IPGeoInZip,
        [Description("ipgeounknown")]
        IPGeoUnknown,
        [Description("ipgeoiszip")]
        IPGeoIsZip,
        [Description("ipgeonotzip")]
        IPGeoIsNotZip,
        [Description("follow")]
        Follow,
        [Description("notfollow")]
        NotFollow,
        [Description("interestcontains")]
<<<<<<< HEAD
        InterestContains
=======
        InterestContains,
        [Description("interestcontainsall")]
        InterestcontainsAll,
        [Description("interestnotcontains")]
        InterestNotContains

>>>>>>> refs/remotes/origin/pr/42

    }
}