using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public partial class ControlPanel_manag : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.User.IsInRole("admin"))
        {
            Response.Redirect("../login.aspx?ReturnUrl=./ControlPanel/manag.aspx");
        }
        if (Request["page"] != null)  
        {
            string req = Request["page"];
            switch (req)
            {
                //========================================================================================= Page Managing
                case "homePage":                              
                    
                    break;
                case "addnews":
                    UC_Mang_News_AddNews  newPage =
                        (UC_Mang_News_AddNews)LoadControl("../UC/Mang/News/AddNews.ascx");
                    phMain.Controls.Add(newPage);
                    break;
                case "newsmanag":
                    UC_Mang_News_newsmanag newsmanag =
                        (UC_Mang_News_newsmanag)LoadControl("../UC/Mang/News/newsmanag.ascx");
                    phMain.Controls.Add(newsmanag);
                    break;
                case "delnews":
                    UC_Mang_News_deletenews deletenews =
                        (UC_Mang_News_deletenews)LoadControl("../UC/Mang/News/deletenews.ascx");
                    phMain.Controls.Add(deletenews);
                    break;
                case "updatenews":
                    UC_Mang_News_updatenewsl updatenews=
                        (UC_Mang_News_updatenewsl)LoadControl("../UC/Mang/News/updatenews.ascx");
                    phMain.Controls.Add(updatenews);
                    break;
                case "addcourse":
                    UC_Mang_course_addcourse newcourse =
                        (UC_Mang_course_addcourse)LoadControl("../UC/Mang/course/addcourse.ascx");
                    phMain.Controls.Add(newcourse);
                    break;
                case "coursemanag":
                    UC_Mang_course_coursemanag coursemanag =
                        (UC_Mang_course_coursemanag)LoadControl("../UC/Mang/course/coursemanag.ascx");
                    phMain.Controls.Add(coursemanag);
                    break;
                case "delcourse":
                    UC_Mang_course_deletecourse deletecourse =
                        (UC_Mang_course_deletecourse)LoadControl("../UC/Mang/course/deletecourse.ascx");
                    phMain.Controls.Add(deletecourse);
                    break;
                case "pishmanag":
                    UC_Mang_coursepish_pishmanag pishmanag =
                        (UC_Mang_coursepish_pishmanag)LoadControl("../UC/Mang/coursepish/pishmanag.ascx");
                    phMain.Controls.Add(pishmanag);
                    break;
                case "coursetimingmanage":
                    UC_Mang_coursetiming_coursetimingmanage coursetimingmanage =
                        (UC_Mang_coursetiming_coursetimingmanage)LoadControl("../UC/Mang/coursetiming/coursetimingmanage.ascx");
                    phMain.Controls.Add(coursetimingmanage);
                    break;
                case "newtype":
                    UC_Mang_coursetype_newcoursetype newtype =
                        (UC_Mang_coursetype_newcoursetype)LoadControl("../UC/Mang/coursetype/newcoursetype.ascx");
                    phMain.Controls.Add(newtype);
                    break;
                case "typemanag":
                    UC_Mang_coursetype_coursetypemanage typemanag =
                        (UC_Mang_coursetype_coursetypemanage)LoadControl("../UC/Mang/coursetype/coursetypemanage.ascx");
                    phMain.Controls.Add(typemanag);
                    break;
                case "deletetype":
                    UC_Mang_coursetype_deletecoursetype deletetype =
                        (UC_Mang_coursetype_deletecoursetype)LoadControl("../UC/Mang/coursetype/deletecoursetype.ascx");
                    phMain.Controls.Add(deletetype);
                    break;
                case "newdore":
                    UC_Mang_dore_adddore newdore =
                        (UC_Mang_dore_adddore)LoadControl("../UC/Mang/dore/adddore.ascx");
                    phMain.Controls.Add(newdore);
                    break;
                case "doremanag":
                    UC_Mang_dore_doremanag doremanag =
                        (UC_Mang_dore_doremanag)LoadControl("../UC/Mang/dore/doremanag.ascx");
                    phMain.Controls.Add(doremanag);
                    break;
                case "deletedore":
                    UC_Mang_dore_deletdore deletedore =
                        (UC_Mang_dore_deletdore)LoadControl("../UC/Mang/dore/deletdore.ascx");
                    phMain.Controls.Add(deletedore);
                    break;
                case "newecourse":
                    UC_Mang_ecourse_addecourse newecourse =
                        (UC_Mang_ecourse_addecourse)LoadControl("../UC/Mang/ecourse/addecourse.ascx");
                    phMain.Controls.Add(newecourse);
                    break;
                case "ecoursemanag":
                    UC_Mang_ecourse_ecoursemanag ecoursemanag =
                        (UC_Mang_ecourse_ecoursemanag)LoadControl("../UC/Mang/ecourse/ecoursemanag.ascx");
                    phMain.Controls.Add(ecoursemanag);
                    break;
                case "deleteecourse":
                   UC_Mang_ecourse_deleteecourse  deleteecourse =
                        (UC_Mang_ecourse_deleteecourse)LoadControl("../UC/Mang/ecourse/deleteecourse.ascx");
                    phMain.Controls.Add(deleteecourse);
                    break;
                case "newmaghtaa":
                    UC_Mang_Maghtaa_addmaghtaa newmaghtaa =
                        (UC_Mang_Maghtaa_addmaghtaa)LoadControl("../UC/Mang/Maghtaa/addmaghtaa.ascx");
                    phMain.Controls.Add(newmaghtaa);
                    break;
                case "managmaghtaa":
                    UC_Mang_Maghtaa_maghtaamanag managmaghtaa =
                        (UC_Mang_Maghtaa_maghtaamanag)LoadControl("../UC/Mang/Maghtaa/maghtaamanag.ascx");
                    phMain.Controls.Add(managmaghtaa);
                    break;
                case "deletemaghtaa":
                    UC_Mang_Maghtaa_deletemaghtaa deletemaghtaa =
                        (UC_Mang_Maghtaa_deletemaghtaa)LoadControl("../UC/Mang/Maghtaa/deletemaghtaa.ascx");
                    phMain.Controls.Add(deletemaghtaa);
                    break;
                case "newmaster":
                    UC_Mang_master_addmaster newmaster =
                        (UC_Mang_master_addmaster)LoadControl("../UC/Mang/master/addmaster.ascx");
                    phMain.Controls.Add(newmaster);
                    break;
                case "managmaster":
                    UC_Mang_master_mastermanag managmaster =
                        (UC_Mang_master_mastermanag)LoadControl("../UC/Mang/master/mastermanag.ascx");
                    phMain.Controls.Add(managmaster);
                    break;
                case "delmaster":
                    UC_Mang_master_deletemasterl deletemaster =
                        (UC_Mang_master_deletemasterl)LoadControl("../UC/Mang/master/deletemasterl.ascx");
                    phMain.Controls.Add(deletemaster);
                    break;
                case "newreshte":
                    UC_Mang_reshte_addreshte newreshte =
                        (UC_Mang_reshte_addreshte)LoadControl("../UC/Mang/reshte/addreshte.ascx");
                    phMain.Controls.Add(newreshte);
                    break;
                case "managreshte":
                    UC_Mang_reshte_reshtemanag managreshte =
                        (UC_Mang_reshte_reshtemanag)LoadControl("../UC/Mang/reshte/reshtemanag.ascx");
                    phMain.Controls.Add(managreshte);
                    break;
                case "deletereshte":
                    UC_Mang_reshte_deletereshte deletereshte =
                        (UC_Mang_reshte_deletereshte)LoadControl("../UC/Mang/reshte/deletereshte.ascx");
                    phMain.Controls.Add(deletereshte);
                    break;
                case "newregtiming":
                         UC_Mang_registertiming_addregistertiming newregtiming =
                        (UC_Mang_registertiming_addregistertiming)LoadControl("../UC/Mang/registertiming/addregistertiming.ascx");
                         phMain.Controls.Add(newregtiming);
                    break;
                case "managregtiming":
                    UC_Mang_registertiming_registertimingmanag managregtiming =
                        (UC_Mang_registertiming_registertimingmanag)LoadControl("../UC/Mang/registertiming/registertimingmanag.ascx");
                    phMain.Controls.Add(managregtiming);
                    break;
                case "delregt":
                   UC_Mang_registertiming_delregistertiming delregistertiming =
                        (UC_Mang_registertiming_delregistertiming)LoadControl("../UC/Mang/registertiming/delregistertiming.ascx");
                   phMain.Controls.Add(delregistertiming);
                    break;
                case "newstudent":
                    UC_Mang_student_addstudent newstudent =
                        (UC_Mang_student_addstudent)LoadControl("../UC/Mang/student/addstudent.ascx");
                    phMain.Controls.Add(newstudent);
                    break;
                case "managstudent":
                    UC_Mang_student_studentmanag managstudent =
                        (UC_Mang_student_studentmanag)LoadControl("../UC/Mang/student/studentmanag.ascx");
                    phMain.Controls.Add(managstudent);
                    break;
                case "deletestudent":
                    UC_Mang_student_deletestudent deletestudent =
                        (UC_Mang_student_deletestudent)LoadControl("../UC/Mang/student/deletestudent.ascx");
                    phMain.Controls.Add(deletestudent);
                    break;
                case "newtuition":
                    UC_Mang_tuition_addtuition newtuition =
                        (UC_Mang_tuition_addtuition)LoadControl("../UC/Mang/tuition/addtuition.ascx");
                    phMain.Controls.Add(newtuition);
                    break;
                case "managtuition":
                    UC_Mang_tuition_tuitionmanag managtuition =
                        (UC_Mang_tuition_tuitionmanag)LoadControl("../UC/Mang/tuition/tuitionmanag.ascx");
                    phMain.Controls.Add(managtuition);
                    break;
                    
                default:
                    break;

            }
        }
    }

    
}
