using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_NurturingAvilableSlots : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNurturingProcessSlots item = new clsNurturingProcessSlots();
    int ItemId = 0;
    string btn1StartTime = "00:00";
    string btn1EndTime = "00:30";
    string btn2StartTime = "00:30";
    string btn2EndTime = "01:00";
    string btn3StartTime = "01:00";
    string btn3EndTime = "01:30";
    string btn4StartTime = "01:30";
    string btn4EndTime = "02:00";
    string btn5StartTime = "02:00";
    string btn5EndTime = "02:30";
    string btn6StartTime = "02:30";
    string btn6EndTime = "03:00";
    string btn7StartTime = "03:00";
    string btn7EndTime = "03:30";
    string btn8StartTime = "03:30";
    string btn8EndTime = "04:00";
    string btn9StartTime = "04:00";
    string btn9EndTime = "04:30";
    string btn10StartTime = "04:30";
    string btn10EndTime = "05:00";
    string btn11StartTime = "05:00";
    string btn11EndTime = "05:30";
    string btn12StartTime = "05:30";
    string btn12EndTime = "06:00";
    string btn13StartTime = "06:00";
    string btn13EndTime = "06:30";
    string btn14StartTime = "06:30";
    string btn14EndTime = "07:00";
    string btn15StartTime = "07:00";
    string btn15EndTime = "07:30";
    string btn16StartTime = "07:30";
    string btn16EndTime = "08:00";
    string btn17StartTime = "08:00";
    string btn17EndTime = "08:30";
    string btn18StartTime = "08:30";
    string btn18EndTime = "09:00";
    string btn19StartTime = "09:00";
    string btn19EndTime = "09:30";
    string btn20StartTime = "09:30";
    string btn20EndTime = "10:00";
    string btn21StartTime = "10:00";
    string btn21EndTime = "10:30";
    string btn22StartTime = "10:30";
    string btn22EndTime = "11:00";
    string btn23StartTime = "11:00";
    string btn23EndTime = "11:30";
    string btn24StartTime = "11:30";
    string btn24EndTime = "12:00";
    string btn25StartTime = "12:00";
    string btn25EndTime = "12:30";
    string btn26StartTime = "12:30";
    string btn26EndTime = "13:00";
    string btn27StartTime = "13:00";
    string btn27EndTime = "13:30";
    string btn28StartTime = "13:30";
    string btn28EndTime = "14:00";
    string btn29StartTime = "14:00";
    string btn29EndTime = "14:30";
    string btn30StartTime = "14:30";
    string btn30EndTime = "15:00";
    string btn31StartTime = "15:00";
    string btn31EndTime = "15:30";
    string btn32StartTime = "15:30";
    string btn32EndTime = "16:00";
    string btn33StartTime = "16:00";
    string btn33EndTime = "16:30";
    string btn34StartTime = "16:30";
    string btn34EndTime = "17:00";
    string btn35StartTime = "17:00";
    string btn35EndTime = "17:30";
    string btn36StartTime = "17:30";
    string btn36EndTime = "18:00";
    string btn37StartTime = "18:00";
    string btn37EndTime = "18:30";
    string btn38StartTime = "18:30";
    string btn38EndTime = "19:00";
    string btn39StartTime = "19:00";
    string btn39EndTime = "19:30";
    string btn40StartTime = "19:30";
    string btn40EndTime = "20:00";
    string btn41StartTime = "20:00";
    string btn41EndTime = "20:30";
    string btn42StartTime = "20:30";
    string btn42EndTime = "21:00";
    string btn43StartTime = "21:00";
    string btn43EndTime = "21:30";
    string btn44StartTime = "21:30";
    string btn44EndTime = "22:00";
    string btn45StartTime = "22:00";
    string btn45EndTime = "22:30";
    string btn46StartTime = "22:30";
    string btn46EndTime = "23:00";
    string btn47StartTime = "23:00";
    string btn47EndTime = "23:30";
    string btn48StartTime = "23:30";
    string btn48EndTime = "23:59";

    int CountNo1 = 0;
    int CountNo2 = 0;
    int CountNo3 = 0;
    int CountNo4 = 0;
    int CountNo5 = 0;
    int CountNo6 = 0;
    int CountNo7 = 0;
    int CountNo8 = 0;
    int CountNo9 = 0;
    int CountNo10 = 0;
    int CountNo11 = 0;
    int CountNo12 = 0;
    int CountNo13 = 0;
    int CountNo14 = 0;
    int CountNo15 = 0;
    int CountNo16 = 0;
    int CountNo17 = 0;
    int CountNo18 = 0;
    int CountNo19 = 0;
    int CountNo20 = 0;
    int CountNo21 = 0;
    int CountNo22 = 0;
    int CountNo23 = 0;
    int CountNo24 = 0;
    int CountNo25 = 0;
    int CountNo26 = 0;
    int CountNo27 = 0;
    int CountNo28 = 0;
    int CountNo29 = 0;
    int CountNo30 = 0;
    int CountNo31 = 0;
    int CountNo32 = 0;
    int CountNo33 = 0;
    int CountNo34 = 0;
    int CountNo35 = 0;
    int CountNo36 = 0;
    int CountNo37 = 0;
    int CountNo38 = 0;
    int CountNo39 = 0;
    int CountNo40 = 0;
    int CountNo41 = 0;
    int CountNo42 = 0;
    int CountNo43 = 0;
    int CountNo44 = 0;
    int CountNo45 = 0;
    int CountNo46 = 0;
    int CountNo47 = 0;
    int CountNo48 = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        BindEmployeeAssignedTasks();
        BindCount1();
        BindCount2();
        BindCount3();
        BindCount4();
        BindCount5();
        BindCount6();
        BindCount7();
        BindCount8();
        BindCount9();
        BindCount10();
        BindCount11();
        BindCount12();
        BindCount13();
        BindCount14();
        BindCount15();
        BindCount16();
        BindCount17();
        BindCount18();
        BindCount19();
        BindCount20();
        BindCount21();
        BindCount22();
        BindCount23();
        BindCount24();
        BindCount25();
        BindCount26();
        BindCount27();
        BindCount28();
        BindCount29();
        BindCount30();
        BindCount31();
        BindCount32();
        BindCount33();
        BindCount34();
        BindCount35();
        BindCount36();
        BindCount37();
        BindCount38();
        BindCount39();
        BindCount40();
        BindCount41();
        BindCount42();
        BindCount43();
        BindCount44();
        BindCount45();
        BindCount46();
        BindCount47();
        BindCount48();
        if (!IsPostBack)
        {
            BindCount1();
            BindCount2();
            BindCount3();
            BindCount4();
            BindCount5();
            BindCount6();
            BindCount7();
            BindCount8();
            BindCount9();
            BindCount10();
            BindCount11();
            BindCount12();
            BindCount13();
            BindCount14();
            BindCount15();
            BindCount16();
            BindCount17();
            BindCount18();
            BindCount19();
            BindCount20();
            BindCount21();
            BindCount22();
            BindCount23();
            BindCount24();
            BindCount25();
            BindCount26();
            BindCount27();
            BindCount28();
            BindCount29();
            BindCount30();
            BindCount31();
            BindCount32();
            BindCount33();
            BindCount34();
            BindCount35();
            BindCount36();
            BindCount37();
            BindCount38();
            BindCount39();
            BindCount40();
            BindCount41();
            BindCount42();
            BindCount43();
            BindCount44();
            BindCount45();
            BindCount46();
            BindCount47();
            BindCount48();
        }
    }
    protected void BindEmployeeAssignedTasks()
    {
        clsNurturingProcessStageTaskAccess objTaskAccess = new clsNurturingProcessStageTaskAccess();
        objTaskAccess.EmployeeId = CurrentUser.CurrentEmployeeId;
        blNurturingTasks.DataSource = objTaskAccess.LoadAll(objTaskAccess);
        blNurturingTasks.DataTextField = "NurturingProcessStageTaskName";
        blNurturingTasks.DataValueField = "NurturingProcessStageTaskId";
        blNurturingTasks.DataBind();
     }
    protected void BindCount1()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn1StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo1 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo1 == 0)
            {
                btn1.Enabled = true;
            }
            else
            {
                btn1.Enabled = false;
            }
        }     
    }
    protected void BindCount2()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn2StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo2 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo2 == 0)
            {
                btn2.Enabled = true;
            }
            else
            {
                btn2.Enabled = false;
            }
        }
    }
    protected void BindCount3()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn3StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo3 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo3 == 0)
            {
                btn3.Enabled = true;
            }
            else
            {
                btn3.Enabled = false;
            }
        }
    }
    protected void BindCount4()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn4StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo4 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo4 == 0)
            {
                btn4.Enabled = true;
            }
            else
            {
                btn4.Enabled = false;
            }
        }
    }
    protected void BindCount5()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn5StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo5 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo5 == 0)
            {
                btn5.Enabled = true;
            }
            else
            {
                btn5.Enabled = false;
            }
        }
    }
    protected void BindCount6()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn6StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo6 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo6 == 0)
            {
                btn6.Enabled = true;
            }
            else
            {
                btn6.Enabled = false;
            }
        }
    }
    protected void BindCount7()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn7StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo7 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo7 == 0)
            {
                btn7.Enabled = true;
            }
            else
            {
                btn7.Enabled = false;
            }
        }
    }
    protected void BindCount8()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn8StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo8 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo8 == 0)
            {
                btn8.Enabled = true;
            }
            else
            {
                btn8.Enabled = false;
            }
        }
    }
    protected void BindCount9()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn9StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo9 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo9 == 0)
            {
                btn9.Enabled = true;
            }
            else
            {
                btn9.Enabled = false;
            }
        }
    }
    protected void BindCount10()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn10StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo10 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo10 == 0)
            {
                btn10.Enabled = true;
            }
            else
            {
                btn10.Enabled = false;
            }
        }
    }
    protected void BindCount11()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn11StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo11 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo11 == 0)
            {
                btn11.Enabled = true;
            }
            else
            {
                btn11.Enabled = false;
            }
        }
    }
    protected void BindCount12()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn12StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo12 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo12 == 0)
            {
                btn12.Enabled = true;
            }
            else
            {
                btn12.Enabled = false;
            }
        }
    }
    protected void BindCount13()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn13StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo13 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo13 == 0)
            {
                btn13.Enabled = true;
            }
            else
            {
                btn13.Enabled = false;
            }
        }
    }
    protected void BindCount14()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn14StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo14 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo14 == 0)
            {
                btn14.Enabled = true;
            }
            else
            {
                btn14.Enabled = false;
            }
        }
    }
    protected void BindCount15()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn15StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo15 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo15 == 0)
            {
                btn15.Enabled = true;
            }
            else
            {
                btn15.Enabled = false;
            }
        }
    }
    protected void BindCount16()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn16StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo16 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo16 == 0)
            {
                btn16.Enabled = true;
            }
            else
            {
                btn16.Enabled = false;
            }
        }
    }
    protected void BindCount17()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn17StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo17 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo17 == 0)
            {
                btn17.Enabled = true;
            }
            else
            {
                btn17.Enabled = false;
            }
        }
    }
    protected void BindCount18()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn18StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo18 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo18 == 0)
            {
                btn18.Enabled = true;
            }
            else
            {
                btn18.Enabled = false;
            }
        }
    }
    protected void BindCount19()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn19StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo19 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo19 == 0)
            {
                btn19.Enabled = true;
            }
            else
            {
                btn19.Enabled = false;
            }
        }
    }
    protected void BindCount20()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn20StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo20 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo20 == 0)
            {
                btn20.Enabled = true;
            }
            else
            {
                btn20.Enabled = false;
            }
        }
    }
    protected void BindCount21()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn21StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo21 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo21 == 0)
            {
                btn21.Enabled = true;
            }
            else
            {
                btn21.Enabled = false;
            }
        }
    }
    protected void BindCount22()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn22StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo22 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo22 == 0)
            {
                btn22.Enabled = true;
            }
            else
            {
                btn22.Enabled = false;
            }
        }
    }
    protected void BindCount23()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn23StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo23 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo23 == 0)
            {
                btn23.Enabled = true;
            }
            else
            {
                btn23.Enabled = false;
            }
        }
    }
    protected void BindCount24()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn24StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo24 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo24 == 0)
            {
                btn24.Enabled = true;
            }
            else
            {
                btn24.Enabled = false;
            }
        }
    }
    protected void BindCount25()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn25StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo25 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo25 == 0)
            {
                btn25.Enabled = true;
            }
            else
            {
                btn25.Enabled = false;
            }
        }
    }
    protected void BindCount26()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn26StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo26 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo26 == 0)
            {
                btn26.Enabled = true;
            }
            else
            {
                btn26.Enabled = false;
            }
        }
    }
    protected void BindCount27()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn27StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo27 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo27 == 0)
            {
                btn27.Enabled = true;
            }
            else
            {
                btn27.Enabled = false;
            }
        }
    }
    protected void BindCount28()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn28StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo28 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo28 == 0)
            {
                btn28.Enabled = true;
            }
            else
            {
                btn28.Enabled = false;
            }
        }
    }
    protected void BindCount29()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn29StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo29 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo29 == 0)
            {
                btn29.Enabled = true;
            }
            else
            {
                btn29.Enabled = false;
            }
        }
    }
    protected void BindCount30()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn30StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo30 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo30 == 0)
            {
                btn30.Enabled = true;
            }
            else
            {
                btn30.Enabled = false;
            }
        }
    }
    protected void BindCount31()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn31StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo31 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo31 == 0)
            {
                btn31.Enabled = true;
            }
            else
            {
                btn31.Enabled = false;
            }
        }
    }
    protected void BindCount32()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn32StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo32 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo32 == 0)
            {
                btn32.Enabled = true;
            }
            else
            {
                btn32.Enabled = false;
            }
        }
    }
    protected void BindCount33()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn33StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo33 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo33 == 0)
            {
                btn33.Enabled = true;
            }
            else
            {
                btn33.Enabled = false;
            }
        }
    }
    protected void BindCount34()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn34StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo34 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo34 == 0)
            {
                btn34.Enabled = true;
            }
            else
            {
                btn34.Enabled = false;
            }
        }
    }
    protected void BindCount35()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn35StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo35 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo35 == 0)
            {
                btn35.Enabled = true;
            }
            else
            {
                btn35.Enabled = false;
            }
        }
    }
    protected void BindCount36()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn36StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo36 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo36 == 0)
            {
                btn36.Enabled = true;
            }
            else
            {
                btn36.Enabled = false;
            }
        }
    }
    protected void BindCount37()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn37StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo37 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo37 == 0)
            {
                btn37.Enabled = true;
            }
            else
            {
                btn37.Enabled = false;
            }
        }
    }
    protected void BindCount38()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn38StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo38 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo38 == 0)
            {
                btn38.Enabled = true;
            }
            else
            {
                btn38.Enabled = false;
            }
        }
    }
    protected void BindCount39()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn39StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo39 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo39 == 0)
            {
                btn39.Enabled = true;
            }
            else
            {
                btn39.Enabled = false;
            }
        }
    }
    protected void BindCount40()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn40StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo40 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo40 == 0)
            {
                btn40.Enabled = true;
            }
            else
            {
                btn40.Enabled = false;
            }
        }
    }
    protected void BindCount41()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn41StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo41 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo41 == 0)
            {
                btn41.Enabled = true;
            }
            else
            {
                btn41.Enabled = false;
            }
        }
    }
    protected void BindCount42()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn42StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo42 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo42 == 0)
            {
                btn42.Enabled = true;
            }
            else
            {
                btn42.Enabled = false;
            }
        }
    }
    protected void BindCount43()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn43StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo43 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo43 == 0)
            {
                btn43.Enabled = true;
            }
            else
            {
                btn43.Enabled = false;
            }
        }
    }
    protected void BindCount44()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn44StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo44 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo44 == 0)
            {
                btn44.Enabled = true;
            }
            else
            {
                btn44.Enabled = false;
            }
        }
    }
    protected void BindCount45()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn45StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo45 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo45 == 0)
            {
                btn45.Enabled = true;
            }
            else
            {
                btn45.Enabled = false;
            }
        }
    }
    protected void BindCount46()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn46StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo46 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo46 == 0)
            {
                btn46.Enabled = true;
            }
            else
            {
                btn46.Enabled = false;
            }
        }
    }
    protected void BindCount47()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn47StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo47 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo47 == 0)
            {
                btn47.Enabled = true;
            }
            else
            {
                btn47.Enabled = false;
            }
        }
    }
    protected void BindCount48()
    {
        if (txtSelectDate.Text != "")
        {
            clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
            obj.SlotDate = Convert.ToDateTime(Date);
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn48StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            obj.SlotStartTime = dt1;
            CountNo48 = obj.LoadNurturingProcessSlotsValidation(obj);
            if (CountNo48 == 0)
            {
                btn48.Enabled = true;
            }
            else
            {
                btn48.Enabled = false;
            }
        }
    }
    protected void BindMessage()
    {
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }
    protected void BindDuplicateMessage()
    {
        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate", true);
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        //System.Threading.Thread.Sleep(6000);
        BindCount1();
        if(CountNo1>0)
        {

            BindDuplicateMessage();
            btn1.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn1StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn1EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "0:00AM To 0:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);
            }
            BindMessage();
            btn1.Enabled = false;
        }
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        //System.Threading.Thread.Sleep(6000);
        BindCount2();
        if (CountNo2 > 0)
        {

            BindDuplicateMessage();
            btn2.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn2StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn2EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "0:30AM TO 1:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);
            }
            BindMessage();
            btn2.Enabled = false;
        }
           
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        BindCount3();
        if (CountNo3 > 0)
        {

            BindDuplicateMessage();
            btn3.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn3StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn3EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "1:00AM TO 1:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);
            }
            BindMessage();
            btn3.Enabled = false;
        }
           
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        BindCount4();
        if(CountNo4>0)
        {
            BindDuplicateMessage();
            btn4.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn4StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn4EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "1:30AM TO 2:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn4.Enabled = false;
        }
       
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        BindCount5();
        if (CountNo5 > 0)
        {
            BindDuplicateMessage();
            btn5.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn5StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn5EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "2:00AM TO 2:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn5.Enabled = false;
        }
       
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        BindCount6();
        if (CountNo6 > 0)
        {
            BindDuplicateMessage();
            btn6.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn6StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn6EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "2:30AM TO 3:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn6.Enabled = false;
        }
        
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        BindCount7();
        if (CountNo7 > 0)
        {
            BindDuplicateMessage();
            btn7.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn7StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn7EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "3:00AM TO 3:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn7.Enabled = false;
        }
        
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        BindCount8();
        if (CountNo8 > 0)
        {
            BindDuplicateMessage();
            btn8.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn8StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn8EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "3:30AM TO 4:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn8.Enabled = false;
        }
       
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        BindCount9();
        if (CountNo9 > 0)
        {
            BindDuplicateMessage();
            btn9.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn9StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn9EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "4:00AM TO 4:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn9.Enabled = false;
        }
       
    }

    protected void btn10_Click(object sender, EventArgs e)
    {
        BindCount10();
        if (CountNo10 > 0)
        {
            BindDuplicateMessage();
            btn10.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn10StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn10EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "4:30AM TO 5:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn10.Enabled = false;
        }
        
    }

    protected void btn11_Click(object sender, EventArgs e)
    {
        BindCount11();
        if (CountNo11 > 0)
        {
            BindDuplicateMessage();
            btn11.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn11StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn11EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "5:00AM TO 5:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn11.Enabled = false;
        }
        
    }

    protected void btn12_Click(object sender, EventArgs e)
    {
        BindCount12();
        if (CountNo12 > 0)
        {
            BindDuplicateMessage();
            btn12.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn12StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn12EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "5:30AM TO 6:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn12.Enabled = false;
        }
       
    }

    protected void btn13_Click(object sender, EventArgs e)
    {
        BindCount13();
        if (CountNo13 > 0)
        {
            BindDuplicateMessage();
            btn13.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn13StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn13EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "6:00AM TO 6:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn13.Enabled = false;
        }
        
    }

    protected void btn14_Click(object sender, EventArgs e)
    {
        BindCount14();
        if (CountNo14 > 0)
        {
            BindDuplicateMessage();
            btn14.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn14StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn14EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "6:30AM TO 7:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn14.Enabled = false;
        }
        
    }

    protected void btn15_Click(object sender, EventArgs e)
    {
        BindCount15();
        if (CountNo15 > 0)
        {
            BindDuplicateMessage();
            btn15.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn15StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn15EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "7:00AM TO 7:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn15.Enabled = false;
        }
        
    }

    protected void btn16_Click(object sender, EventArgs e)
    {
        BindCount16();
        if (CountNo16 > 0)
        {
            BindDuplicateMessage();
            btn16.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn16StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn16EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "7:30AM TO 8:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn16.Enabled = false;
        }
        
    }

    protected void btn17_Click(object sender, EventArgs e)
    {
        BindCount17();
        if (CountNo17 > 0)
        {
            BindDuplicateMessage();
            btn17.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn17StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn17EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "8:00AM TO 8:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn17.Enabled = false;
        }
        
    }

    protected void btn18_Click(object sender, EventArgs e)
    {
        BindCount18();
        if (CountNo18 > 0)
        {
            BindDuplicateMessage();
            btn18.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn18StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn18EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "8:30AM TO 9:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn18.Enabled = false;
        }
       
    }

    protected void btn19_Click(object sender, EventArgs e)
    {
        BindCount19();
        if (CountNo19 > 0)
        {
            BindDuplicateMessage();
            btn19.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn19StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn19EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "9:00AM TO 9:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn19.Enabled = false;
        }
        
    }

    protected void btn20_Click(object sender, EventArgs e)
    {
        BindCount20();
        if (CountNo20 > 0)
        {
            BindDuplicateMessage();
            btn20.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn20StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn20EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "9:30AM TO 10:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn20.Enabled = false;
        }
        
    }

    protected void btn21_Click(object sender, EventArgs e)
    {
        BindCount21();
        if (CountNo21 > 0)
        {
            BindDuplicateMessage();
            btn21.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn21StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn21EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "10:00AM TO 10:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn21.Enabled = false;
        }
       
    }

    protected void btn22_Click(object sender, EventArgs e)
    {
        BindCount22();
        if (CountNo22 > 0)
        {
            BindDuplicateMessage();
            btn22.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn22StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn22EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "10:30AM TO 11:00AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn22.Enabled = false;
        }
        
    }

    protected void btn23_Click(object sender, EventArgs e)
    {
        BindCount23();
        if (CountNo23 > 0)
        {
            BindDuplicateMessage();
            btn23.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn23StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn23EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "11:00AM TO 11:30AM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn23.Enabled = false;
        }
       
    }

    protected void btn24_Click(object sender, EventArgs e)
    {
        BindCount24();
        if (CountNo24 > 0)
        {
            BindDuplicateMessage();
            btn24.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn24StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn24EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "11:30AM TO 12:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn24.Enabled = false;
        }
        
    }

    protected void btn25_Click(object sender, EventArgs e)
    {
        BindCount25();
        if (CountNo25 > 0)
        {
            BindDuplicateMessage();
            btn25.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn25StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn25EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "12:00PM TO 12:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn25.Enabled = false;
        }
       
    }

    protected void btn26_Click(object sender, EventArgs e)
    {
        BindCount26();
        if (CountNo26 > 0)
        {
            BindDuplicateMessage();
            btn26.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn26StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn26EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "12:30PM TO 1:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn26.Enabled = false;
        }
        
    }

    protected void btn27_Click(object sender, EventArgs e)
    {
        BindCount27();
        if (CountNo27 > 0)
        {
            BindDuplicateMessage();
            btn27.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn27StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn27EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "1:00PM TO 1:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn27.Enabled = false;
        }
        
    }

    protected void btn28_Click(object sender, EventArgs e)
    {
        BindCount28();
        if (CountNo28 > 0)
        {
            BindDuplicateMessage();
            btn28.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn28StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn28EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "1:30PM TO 2:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn28.Enabled = false;
        }
        
    }

    protected void btn29_Click(object sender, EventArgs e)
    {
        BindCount29();
        if (CountNo29 > 0)
        {
            BindDuplicateMessage();
            btn29.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn29StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn29EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "2:00PM TO 2:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn29.Enabled = false;
        }
        
    }

    protected void btn30_Click(object sender, EventArgs e)
    {
        BindCount30();
        if (CountNo30 > 0)
        {
            BindDuplicateMessage();
            btn30.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn30StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn30EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "2:30PM TO 3:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn30.Enabled = false;
        }
        
    }

    protected void btn31_Click(object sender, EventArgs e)
    {
        BindCount31();
        if (CountNo31 > 0)
        {
            BindDuplicateMessage();
            btn31.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn31StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn31EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "3:00PM TO 3:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn31.Enabled = false;
        }
        
    }

    protected void btn32_Click(object sender, EventArgs e)
    {
        BindCount32();
        if (CountNo32 > 0)
        {
            BindDuplicateMessage();
            btn32.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn32StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn32EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "3:30PM TO 4:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn32.Enabled = false;
        }
       
    }

    protected void btn33_Click(object sender, EventArgs e)
    {
        BindCount33();
        if (CountNo33 > 0)
        {
            BindDuplicateMessage();
            btn33.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn33StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn33EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "4:00PM TO 4:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn33.Enabled = false;
        }
       
    }

    protected void btn34_Click(object sender, EventArgs e)
    {
        BindCount34();
        if (CountNo34 > 0)
        {
            BindDuplicateMessage();
            btn34.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn34StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn34EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "4:30PM TO 5:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn34.Enabled = false;
        }
        
    }

    protected void btn35_Click(object sender, EventArgs e)
    {
        BindCount35();
        if (CountNo35 > 0)
        {
            BindDuplicateMessage();
            btn35.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn35StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn35EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "5:00PM TO 5:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn35.Enabled = false;
        }
        
    }

    protected void btn36_Click(object sender, EventArgs e)
    {
        BindCount36();
        if (CountNo36 > 0)
        {
            BindDuplicateMessage();
            btn36.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn36StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn36EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "5:30PM TO 6:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn36.Enabled = false;
        }
        
    }



    protected void btn37_Click(object sender, EventArgs e)
    {
        BindCount37();
        if (CountNo37 > 0)
        {
            BindDuplicateMessage();
            btn37.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn37StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn37EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "6:00PM TO 6:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn37.Enabled = false;
        }
        
    }

    protected void btn38_Click(object sender, EventArgs e)
    {
        BindCount38();
        if(CountNo38>0)
        {
            BindDuplicateMessage();
            btn38.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn38StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn38EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "6:30PM TO 7:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn38.Enabled = false;
        }
        
    }

    protected void btn39_Click(object sender, EventArgs e)
    {
        BindCount39();
        if(CountNo39>0)
        {
            BindDuplicateMessage();
            btn39.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn39StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn39EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "7:00PM TO 7:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn39.Enabled = false;
        }
        
    }

    protected void btn40_Click(object sender, EventArgs e)
    {
        BindCount40();
        if(CountNo40>0)
        {
            BindDuplicateMessage();
            btn40.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn40StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn40EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "7:30PM TO 8:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn40.Enabled = false;
        }
        
    }

    protected void btn41_Click(object sender, EventArgs e)
    {
        BindCount41();
        if(CountNo41>0)
        {
            BindDuplicateMessage();
            btn41.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn41StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn41EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "8:00PM TO 8:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn41.Enabled = false;
        }
        
    }

    protected void btn42_Click(object sender, EventArgs e)
    {
        BindCount42();
        if(CountNo42>0)
        {
            BindDuplicateMessage();
            btn42.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn42StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn42EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "8:30PM TO 9:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn42.Enabled = false;
        }
       
    }

    protected void btn43_Click(object sender, EventArgs e)
    {
        BindCount43();
        if(CountNo43>0)
        {
            BindDuplicateMessage();
            btn43.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn43StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn43EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "9:00PM TO 9:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn43.Enabled = false;
        }
       
    }

    protected void btn44_Click(object sender, EventArgs e)
    {
        BindCount44();
        if(CountNo44>0)
        {
            BindDuplicateMessage();
            btn44.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn44StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn44EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "9:30PM TO 10:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn44.Enabled = false;
        }
       
    }

    protected void btn45_Click(object sender, EventArgs e)
    {
        BindCount45();
        if(CountNo45>0)
        {
            BindDuplicateMessage();
            btn45.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn45StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn45EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "10:00PM TO 10:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn45.Enabled = false;
        }
       
    }

    protected void btn46_Click(object sender, EventArgs e)
    {
        BindCount46();
        if(CountNo46>0)
        {
            BindDuplicateMessage();
            btn46.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn46StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn46EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "10:30PM TO 11:00PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn46.Enabled = false;
        }
        
    }

    protected void btn47_Click(object sender, EventArgs e)
    {
        BindCount47();
        if(CountNo47>0)
        {
            BindDuplicateMessage();
            btn47.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn47StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn47EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "11:00PM TO 11:30PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn47.Enabled = false;
        }
       
    }

    protected void btn48_Click(object sender, EventArgs e)
    {
        BindCount48();
        if(CountNo48>0)
        {
            BindDuplicateMessage();
            btn48.Enabled = false;
        }
        else
        {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            Item.NurturingProcessStageTaskId = 0;
            Item.ParticipantId = 0;
            if (txtSelectDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtSelectDate.Text, "dd/MM/yyyy", null);
                Item.SlotDate = Convert.ToDateTime(Date);
                DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn48StartTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotStartTime = dt1;
                DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(Date.ToString("dd/MM/yyyy") + " " + btn48EndTime, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
                Item.SlotEndTime = dt2;
                Item.IsSlotAssigned = false;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.StartEndTime = "11:30PM TO 11:59PM";
                Item.NurturingProcessId = 0;
                Item.SlotsStatusId = 1;
                Item.AddUpdate(Item);

            }
            BindMessage();
            btn48.Enabled = false;
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingAvilableSlotsSearch.aspx");
    }
}