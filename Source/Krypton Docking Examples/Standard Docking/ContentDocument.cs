﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012 - 2019. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.450)
//  Version 5.450.0.0  www.ComponentFactory.com
//
// *****************************************************************************

using System;
using System.Windows.Forms;

namespace StandardDocking
{
    public partial class ContentDocument : UserControl
    {
        public ContentDocument()
        {
            InitializeComponent();
        }

        private void ContentDocument_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ContentDocument_Load");
        }
    }
}
