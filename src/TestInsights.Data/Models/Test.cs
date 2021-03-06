﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace TestInsights.Models
{
    public class Test : ObservableObject
    {
        private TestClass _class;
        private string _name;

        public TestClass Class
        {
            get { return _class; }
            set { Set(nameof(Class), ref _class, value); }
        }

        public string Name
        {
            get { return _name; }
            set { Set(nameof(Name), ref _name, value); }
        }

        public ICollection<TestResult> Results { get; } = new ObservableCollection<TestResult>();
    }
}
