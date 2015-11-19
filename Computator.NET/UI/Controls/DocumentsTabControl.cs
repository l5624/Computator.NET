﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Computator.NET.UI.Controls
{
    public class DocumentsTabControl : TabControl
    {
        private TabPage addTabPage;
        private ToolStripMenuItem cloneTabToolStripMenuItem;
        private ToolStripMenuItem closeOtherTabsToolStripMenuItem;
        private ToolStripMenuItem closeTabsToTheLeftToolStripMenuItem;
        private ToolStripMenuItem closeTabsToTheRightToolStripMenuItem;
        private ToolStripMenuItem closeTabToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        //public Dictionary<string,string> Documents { get; private set; }
        private int id = 2;
        private ImageList imageList1;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;

        public DocumentsTabControl()
        {
            InitializeComponent();
            IntPtr h = this.Handle;
        }

        private void InitializeComponent()
        {
            var resources = new ComponentResourceManager(typeof (DocumentsTabControl));
            contextMenuStrip1 = new ContextMenuStrip();
            newTabToolStripMenuItem = new ToolStripMenuItem();
            cloneTabToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeTabToolStripMenuItem = new ToolStripMenuItem();
            closeOtherTabsToolStripMenuItem = new ToolStripMenuItem();
            closeTabsToTheRightToolStripMenuItem = new ToolStripMenuItem();
            closeTabsToTheLeftToolStripMenuItem = new ToolStripMenuItem();
            addTabPage = new TabPage();
            imageList1 = new ImageList();
            SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // this
            // 
            ContextMenuStrip = contextMenuStrip1;
            TabPages.Add("NewFile1", "NewFile1", 1);
            TabPages.Add(addTabPage);
            Dock = DockStyle.Fill;
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular,
                GraphicsUnit.Point, 0);
            ImageList = imageList1;
            Location = new Point(0, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "this";
            SelectedIndex = 0;
            Size = new Size(1010, 27);
            TabIndex = 0;
            SelectedIndexChanged += this_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[]
            {
                newTabToolStripMenuItem,
                cloneTabToolStripMenuItem,
                toolStripSeparator1,
                closeTabToolStripMenuItem,
                closeOtherTabsToolStripMenuItem,
                closeTabsToTheRightToolStripMenuItem,
                closeTabsToTheLeftToolStripMenuItem
            });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(191, 142);
            // 
            // newTabToolStripMenuItem
            // 
            newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            newTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            newTabToolStripMenuItem.Size = new Size(190, 22);
            newTabToolStripMenuItem.Text = "New tab";
            newTabToolStripMenuItem.Click += newTabToolStripMenuItem_Click;
            // 
            // cloneTabToolStripMenuItem
            // 
            cloneTabToolStripMenuItem.Name = "cloneTabToolStripMenuItem";
            cloneTabToolStripMenuItem.Size = new Size(190, 22);
            cloneTabToolStripMenuItem.Text = "Clone tab";
            cloneTabToolStripMenuItem.Click += cloneTabToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // closeTabToolStripMenuItem
            // 
            closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            closeTabToolStripMenuItem.Size = new Size(190, 22);
            closeTabToolStripMenuItem.Text = "Close tab";
            closeTabToolStripMenuItem.Click += closeTabToolStripMenuItem_Click;
            // 
            // closeOtherTabsToolStripMenuItem
            // 
            closeOtherTabsToolStripMenuItem.Name = "closeOtherTabsToolStripMenuItem";
            closeOtherTabsToolStripMenuItem.Size = new Size(190, 22);
            closeOtherTabsToolStripMenuItem.Text = "Close other tabs";
            closeOtherTabsToolStripMenuItem.Click += closeOtherTabsToolStripMenuItem_Click;
            // 
            // closeTabsToTheRightToolStripMenuItem
            // 
            closeTabsToTheRightToolStripMenuItem.Name = "closeTabsToTheRightToolStripMenuItem";
            closeTabsToTheRightToolStripMenuItem.Size = new Size(190, 22);
            closeTabsToTheRightToolStripMenuItem.Text = "Close tabs to the right";
            closeTabsToTheRightToolStripMenuItem.Click += closeTabsToTheRightToolStripMenuItem_Click;
            // 
            // closeTabsToTheLeftToolStripMenuItem
            // 
            closeTabsToTheLeftToolStripMenuItem.Name = "closeTabsToTheLeftToolStripMenuItem";
            closeTabsToTheLeftToolStripMenuItem.Size = new Size(190, 22);
            closeTabsToTheLeftToolStripMenuItem.Text = "Close tabs to the left";
            closeTabsToTheLeftToolStripMenuItem.Click += closeTabsToTheLeftToolStripMenuItem_Click;
            // 
            // tabPage1
            // 

            // 
            // addTabPage
            // 
            addTabPage.Location = new Point(4, 33);
            addTabPage.Margin = new Padding(2);
            addTabPage.Name = "addTabPage";
            addTabPage.Padding = new Padding(2);
            addTabPage.Size = new Size(1002, 0);
            addTabPage.TabIndex = 1;
            addTabPage.Text = " ➕";
            addTabPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ImageStream =
                ((ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "saved.png");
            imageList1.Images.SetKeyName(1, "unsaved.png");
            // 
            // DocumentsTabControl
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular,
                GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            MinimumSize = new Size(800, 27);
            Name = "DocumentsTabControl";
            Size = new Size(1010, 27);
            ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        public void AddTab(string filename = "")
        {
            var tabPage = new TabPage();
            if (string.IsNullOrEmpty(filename))
            {
                tabPage.Text = "NewFile" + id.ToString();
                tabPage.ImageIndex = 1;
                tabPage.Name= "NewFile" + id.ToString();

            }
            else
            {
                tabPage.Text = filename;
                tabPage.ImageIndex = 0;
                tabPage.Name = filename;
            }

            TabPages.Insert(TabPages.Count - 1, tabPage);
            SelectedIndex = TabPages.IndexOf(tabPage);
            id++;
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPages.Remove(SelectedTab);
        }

        private void closeOtherTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in TabPages)
            {
                if(tabPage!=SelectedTab && tabPage!=addTabPage)
                       TabPages.Remove(tabPage);
            }
            // Documents.Remove(this.SelectedTab.Text);

            //this.TabPages.();
        }

        private void closeTabsToTheRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = SelectedIndex+1; TabPages[i] != SelectedTab && TabPages[i] != addTabPage;)
            {
                    TabPages.RemoveAt(i);
            }
        }

        private void closeTabsToTheLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; TabPages[i] != SelectedTab && TabPages[i] != addTabPage;)
            {
                TabPages.RemoveAt(i);
            }
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void cloneTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void this_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTab == addTabPage)
            {
                AddTab();
            }
        }
    }
}