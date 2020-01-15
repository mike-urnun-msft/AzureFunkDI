using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunkDI
{
    public class MyOptions:IMyOptions
    {
        public string MyCustomSetting { get; set; }
    }
}
