﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keys_Onboarding.Global;
using OpenQA.Selenium.Support.PageObjects;

namespace Keys_Onboarding.Pages
{
    class TenantDetailsPage
    {
        public TenantDetailsPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

    }
}
