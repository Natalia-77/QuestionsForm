﻿using Question.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class Form1 : Form
    {
        private readonly MyContext _context;

        //first  commit Vlasiyk N.
        // Hello, Mars!!!
        public Form1()
        {
            _context = new MyContext();
            AddData.Add(_context);
            InitializeComponent();
        }

    }
}