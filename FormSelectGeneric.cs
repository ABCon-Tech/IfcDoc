﻿// Name:        FormSelectGeneric.cs
// Description: Dialog box for selecting enumeration
// Copyright:   (c) 2013 BuildingSmart International Ltd.
// License:     http://www.buildingsmart-tech.org/legal

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IfcDoc.Schema.DOC;

namespace IfcDoc
{
	public partial class FormSelectGeneric<T> : Form where T : DocObject
	{
		DocProject m_project;

		public FormSelectGeneric()
		{
			InitializeComponent();
			this.Text = "Select " + typeof(T).Name.Substring(3);
		}


		public FormSelectGeneric(DocProject project, T selection, List<T> list) : this()
		{
			this.m_project = project;

			Dictionary<string, T> processed = new Dictionary<string, T>();

			foreach (T generic in list)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Tag = constant;
				if (constant.Name != null)
				{
					lvi.Text = constant.Name +  (processed.ContainsKey(constant.Name) ? "_" + BuildingSmart.Utilities.Conversion.GlobalId.Format( constant.Uuid) : "");
				}
				else
				{
					lvi.Text = (processed.ContainsKey(constant.Name) ? "_" + BuildingSmart.Utilities.Conversion.GlobalId.Format(constant.Uuid) : "");
				}

				lvi.ImageIndex = 0;
				this.listView.Items.Add(lvi);

				if (selection == generic)
				{
					lvi.Selected = true;
				}
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (this.listView.SelectedItems.Count == 1)
			{
				this.listView.SelectedItems[0].EnsureVisible();
			}
		}

		public T Selection
		{
			get
			{
				if (this.listView.SelectedItems.Count == 1)
				{
					return this.listView.SelectedItems[0].Tag as T;
				}
				return null;
			}
		}
	}
}
