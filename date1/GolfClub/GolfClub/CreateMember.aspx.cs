﻿using GolfClub.DAL;
using GolfClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GolfClub
{
    public partial class CreateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClubMemberDbManager objclubMemberDbManager = new ClubMemberDbManager();
            Member memberModel = new Member();
            memberModel.Name = txtName.Text;
            memberModel.Gender = drpGender.SelectedItem.Text;
            memberModel.MemberFree = Convert.ToDouble(txtfrees.Text);
            memberModel = objclubMemberDbManager.CreateMember(memberModel);
            lblMessage.Text = "Member Created Successfully";

        }
    }
}