﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginVm;

        public ShellViewModel(LoginViewModel loginVm)
        {
            _loginVm = loginVm;
            ActivateItem(_loginVm);
        }
    }
}