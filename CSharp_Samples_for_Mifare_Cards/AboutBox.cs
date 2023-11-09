
//****************************************************************************** 
//* @file   AboutBox.cs
//* @brief  <Brief description>
//* This displays the information on about window box
//*
//* <Long description>
//*  The Information shown in the AboutBox is 
//*  C# Sample for Mifare cards
//*  Copyright (c) 2012 HID Global Corp.
//*  V1.0.0.1
//*  
//****************************************************************************** 
//* $Id$ 
//*
//* @date January 18, 2012
//* @version 1.0.0.1
//* 
//* Copyright © 2012 HID Global Corporation.
//* All rights reserved. 
//* Use is subject to license terms
//*******************************************************************************




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_Samples_for_Mifare_Cards
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = "About..."; 
          
          
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hidglobal.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

        }


    }
}
