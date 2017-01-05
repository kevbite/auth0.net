﻿using System;

namespace Auth0.ManagementApi.Models
{

    /// <summary>
    ///vb
    /// </summary>
    public class DailyStatistics
    {
        /// <summary>
        /// The date to which the stats belong.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The amount of logins on the date.
        /// </summary>
        public int Logins { get; set; }

        /// <summary>
        /// The amount of signups on the date.
        /// </summary>
        public int SignUps { get; set; }

    }

}