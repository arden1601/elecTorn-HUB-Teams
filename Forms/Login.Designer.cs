﻿namespace elecTorn_HUB_Teams.Forms;
using elecTorn_HUB_Teams.Functions;

partial class Login
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        SuspendLayout();

        Functions.InitPage(this, "Login", Login_Load);

        ResumeLayout(false);
    }
}
