﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SamanageAPI
{
    [JsonObject]
    public class User : Principal
    {
        #region Fields
        private DateTime? _created;
        private Department _department;
        private DateTime? _lastLogin;
        private User _manager;
        private string _mobilePhone;
        private string _phone;
        private Role _role;
        private Site _site;
        private string _title;
        #endregion // Fields

        #region Properties
        [JsonProperty("created_at")]
        public DateTime? Created
        {
            get { return _created; }
            internal set { SetProperty(ref _created, value); }
        }

        [JsonProperty("department")]
        public Department Department
        {
            get { return _department; }
            set { SetProperty(ref _department, value); }
        }

        [Required]
        [JsonRequired]
        public override string Email
        {
            get { return base.Email; }
            set { base.Email = value; }
        }

        [JsonProperty("last_login")]
        public DateTime? LastLogin
        {
            get { return _lastLogin; }
            internal set { SetProperty(ref _lastLogin, value); }
        }

        [JsonProperty("reports_to")]
        public User Manager
        {
            get { return _manager; }
            set { SetProperty(ref _manager, value); }
        }

        [JsonProperty("mobile_phone")]
        public string MobilePhone
        {
            get { return _mobilePhone; }
            set { SetProperty(ref _mobilePhone, value); }
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        [JsonProperty("role")]
        public Role Role
        {
            get { return _role; }
            internal set { SetProperty(ref _role, value); }
        }

        [JsonProperty("site")]
        public Site Site
        {
            get { return _site; }
            set { SetProperty(ref _site, value); }
        }

        [JsonProperty("title")]
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #endregion // Properties

        #region Constructors
        internal User() : base () { }
        public User(SamanageClient client) : base(client) { }
        #endregion // Constructors
    }
}
