﻿namespace MyClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMailService
    {
        void SendMail(string from, string to);
    }
}
