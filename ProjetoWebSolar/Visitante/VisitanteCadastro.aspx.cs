using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzLibSolar;
using System.Data;
using System.Configuration;
using System.IO;

namespace ProjetoWebSolar.Visitante
{
    public partial class VisitanteCadastro : clBootStrap
    {
        private struct Autorizacao
        {
            public string cmpAUTHID { get; set; }
            public string SHORTNAME { get; set; }
            public string NAME { get; set; }
        }

        private void ExibirMensagemErro(string msg)
        {
            Site master = (Site)this.Master;
            master.Mensagem(msg, ProjetoWebSolar.Site.TipoMensagem.Erro, "");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var p = Master as Site;
            if (p != null)
                p.Titulo = "Cadastro de Visitantes";

            imgfoto.ImageUrl = "~/Content/images/a.png";
            //try
            {
                //    if (IsPostBack == false)
                //    {
                //        string idPerson = this.Request.QueryString["idPERSON"];
                //        string Origem = this.Request.QueryString["Origem"];
                //        string PersID = this.Request.QueryString["PersID"];

                //        txtdatainicio.Text = DateTime.Now.Date.Date.ToShortDateString();
                //        txtdatafim.Text = DateTime.Now.Date.Date.ToShortDateString();

                //        CarregarDropList();
                //        CarregarTipoVisitante();
                //        if (idPerson == null)
                //        {
                //            Session.Add("idPerson", null);
                //            Session.Add("Origem", "SQL");
                //            Session.Add("PersID", null);
                //        }
                //        else
                //        {
                //            Session.Add("idPerson", idPerson);
                //            Session.Add("Origem", Origem);
                //            Session.Add("PersID", PersID);
                //        }

                //        if (idPerson != null)
                //        {
                //            CarregarPessoa(idPerson, PersID);
                //        }
                //        CarregarAutorizacoes();


                //    }
                //}
                //catch (Exception ex)
                //{

                //    ExibirMensagemErro("Erro ao carregar a página!:" + ex.Message);
                //}

                //}
                //private void CarregarAutorizacoes()
                //{
                //    try
                //    {
                //        ///Autorizações

                //        List<Autorizacao> lstAutorizacoes = new List<Autorizacao>();

                //        DataTable dtAutorizacoes = tblAUTHORIZATIONS.GET(Global.GetConnection());
                //        for (int i = 0; i < dtAutorizacoes.Rows.Count; i++)
                //        {
                //            Autorizacao auto = new Autorizacao();
                //            auto.cmpAUTHID = dtAutorizacoes.Rows[i]["AUTHID"].ToString();
                //            auto.NAME = dtAutorizacoes.Rows[i]["NAME"].ToString();
                //            auto.SHORTNAME = dtAutorizacoes.Rows[i]["SHORTNAME"].ToString();
                //            lstAutorizacoes.Add(auto);
                //        }
                //        grvautorizacoes.DataSource = lstAutorizacoes;
                //        grvautorizacoes.DataBind();
                //        Session.Add("Autorizacoes", lstAutorizacoes);


                //        ///Autorizações de Pessoas
                //        List<Autorizacao> lstAutorizacoesPessoa = new List<Autorizacao>();

                //        if (Session["idPerson"] != null)
                //        {
                //            if (Session["Origem"].ToString() == "SQL")
                //            {
                //                DataTable dt = tblAUTHPERPERSON.GETAutorizacaoPessoa(Global.GetConnection(), Session["idPerson"].ToString());
                //                for (int i = 0; i < dt.Rows.Count; i++)
                //                {
                //                    Autorizacao auto = new Autorizacao();
                //                    auto.cmpAUTHID = dt.Rows[i]["cmpAUTHID"].ToString();
                //                    auto.NAME = dt.Rows[i]["NAME"].ToString();
                //                    auto.SHORTNAME = dt.Rows[i]["SHORTNAME"].ToString();
                //                    lstAutorizacoesPessoa.Add(auto);

                //                    txtdatainicio.Text = dt.Rows[i]["cmpVALIDFROM"].ToString();
                //                    txtdatafim.Text = dt.Rows[i]["cmpVALIDUNTIL"].ToString();
                //                }
                //            }
                //        }

                //        grvautorizacaoselecionada.DataSource = lstAutorizacoesPessoa;
                //        grvautorizacaoselecionada.DataBind();
                //        Session.Add("AutorizacoesPessoas", lstAutorizacoesPessoa);
                //    }
                //    catch (Exception ex)
                //    {

                //        ExibirMensagemErro("Erro ao carregar as autorizações!:" + ex.Message);
                //    }
                //}
                //private void CarregarPessoa(string idPERSON, string _PERSID)
                //{

                //    try
                //    {
                //        #region Carregar Pessoa
                //        tblPERSONS tbl = new tblPERSONS(Global.GetConnection(), idPERSON,_PERSID, Session["Origem"].ToString());
                //        txtNome.Text = tbl.cmpFIRSTNAME + " " + tbl.cmpLASTNAME;
                //        txtnascimento.Text = tbl.cmpDATEOFBIRTH;
                //        txtCpf.Text = tbl.cmpPASSPORTNO.PadLeft(11, '0');

                //        txtRG.Text = tbl.cmpIDNUMBER;
                //        txtTelFixo.Text = tbl.cmpPHONEOFFICE;
                //        txtTelCelular.Text = tbl.cmpPHONEMOBILE;
                //        txtemail.Text = tbl.cmpEMAIL;
                //        txtplaca.Text = tbl.cmpNUMBERPLATE;
                //        txtmarca.Text = tbl.cmpRESERVE2;
                //        txtmodelo.Text = tbl.cmpRESERVE3;

                //        //Preencher Tipo Visitante

                //        if (string.IsNullOrEmpty(tbl.cmpPERSCLASSID) == false)
                //        {
                //            ddltipovisitante.ClearSelection();
                //            ddltipovisitante.Items.FindByValue(tbl.cmpPERSCLASSID).Selected = true;
                //        }

                //        if (string.IsNullOrEmpty(tbl.cmpCOMPANYID) == false)
                //        {
                //            ddlempresa.ClearSelection();
                //            ddlempresa.Items.FindByValue(tbl.cmpCOMPANYID).Selected = true;
                //        } 

                //        if(string.IsNullOrEmpty(tbl.cmpREASON)==false)
                //        {
                //            ddlmotivodavisita.Text=tbl.cmpREASON;
                //        }
                //        #endregion


                //        #region Carregar Foto
                //        if (Session["Origem"].ToString() == "BIS")
                //        {
                //            //Fotos
                //            string diretorio = ConfigurationSettings.AppSettings["DirFotos"].ToString();
                //            diretorio += "//" + Session["PersID"].ToString() + ".jpg";
                //            if (File.Exists(diretorio) == true)
                //            {
                //                byte[] imageBytes = System.IO.File.ReadAllBytes(diretorio);
                //                string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                //                //this.testImage.Src = "data:image/jpeg;base64," + base64String;

                //                imgfoto.ImageUrl = "data:image/jpeg;base64," + base64String;
                //            }
                //            else
                //            {
                //                string imgLocal = Server.MapPath("../Imagens/logo1.png");
                //                byte[] imageBytes = System.IO.File.ReadAllBytes(imgLocal);
                //                string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                //                //this.testImage.Src = "data:image/jpeg;base64," + base64String;

                //                imgfoto.ImageUrl = "data:image/jpeg;base64," + base64String;
                //            }
                //        }
                //        else
                //        {
                //            string diretorio = ConfigurationSettings.AppSettings["DirFotos"].ToString();
                //            diretorio += "//" + tbl.cmpPERSID + ".jpg";
                //            if (File.Exists(diretorio) == true)
                //            {
                //                byte[] imageBytes = System.IO.File.ReadAllBytes(diretorio);
                //                string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                //                //this.testImage.Src = "data:image/jpeg;base64," + base64String;

                //                imgfoto.ImageUrl = "data:image/jpeg;base64," + base64String;
                //            }
                //            else
                //            {
                //                string imgLocal = Server.MapPath("../Imagens/logo1.png");
                //                byte[] imageBytes = System.IO.File.ReadAllBytes(imgLocal);
                //                string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                //                //this.testImage.Src = "data:image/jpeg;base64," + base64String;

                //                imgfoto.ImageUrl = "data:image/jpeg;base64," + base64String;
                //            }
                //        } 
                //        #endregion
                //    }
                //    catch (Exception ex)
                //    {
                //        ExibirMensagemErro("Erro ao carregar a pessoa!:" + ex.Message);
                //    }

                //}

                //private void CarregarDropList()
                //{
                //    try
                //    {



                //        ddlempresa.DataSource = hzLibSolar.BIS.COMPANIES.GET(Global.GetConnection());
                //        ddlempresa.DataBind();
                //    }
                //    catch (Exception ex)
                //    {
                //        ExibirMensagemErro("Erro ao carregar os tipos de pessoas!:" + ex.Message);
                //    }


                //}
                //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
                //{
                //    try
                //    {
                //        if (Calendar1.ToolTip == "Data Inicio")
                //        {
                //            txtdatainicio.Text = Calendar1.SelectedDate.ToShortDateString();
                //        }
                //        else
                //        {
                //            txtdatafim.Text = Calendar1.SelectedDate.ToShortDateString();
                //        }
                //    }
                //    catch (Exception ex)
                //    {

                //        ExibirMensagemErro("Erro ao selecionar o calendário!:" + ex.Message);
                //    }

                //}

                //protected void btncalendar2_Click(object sender, EventArgs e)
                //{
                //    Calendar1.ToolTip = "Data Inicio";
                //    ModCentro.Show();

                //}

                //protected void btncalendar3_Click(object sender, EventArgs e)
                //{
                //    Calendar1.ToolTip = "Data Fim";
                //    ModCentro.Show();
                //}

                //protected void btnproximo_Click(object sender, EventArgs e)
                //{
                //    try
                //    {
                //        List<Autorizacao> lstAutoPessoas = (List<Autorizacao>)Session["AutorizacoesPessoas"];
                //        List<Autorizacao> lstAuto = (List<Autorizacao>)Session["Autorizacoes"];

                //        for (int i = 0; i < grvautorizacoes.Rows.Count; i++)
                //        {
                //            CheckBox ck = (CheckBox)grvautorizacoes.Rows[i].FindControl("ckSelecionar");
                //            if (ck.Checked == true)
                //            {
                //                Autorizacao aut = new Autorizacao();
                //                aut.cmpAUTHID = grvautorizacoes.DataKeys[i][0].ToString();
                //                aut.SHORTNAME = grvautorizacoes.DataKeys[i][1].ToString();
                //                lstAutoPessoas.Add(aut);
                //                //lstAuto.Remove(lstAuto[i]);
                //            }
                //        }

                //        foreach (Autorizacao item in lstAutoPessoas)
                //        {
                //            Autorizacao aut= lstAuto.Find(x => x.cmpAUTHID == item.cmpAUTHID);

                //                lstAuto.Remove(aut);
                //        }
                //        Session["AutorizacoesPessoas"] = lstAutoPessoas;
                //        Session["Autorizacoes"] = lstAuto;

                //        grvautorizacoes.DataSource = lstAuto;
                //        grvautorizacoes.DataBind();

                //        grvautorizacaoselecionada.DataSource = lstAutoPessoas;
                //        grvautorizacaoselecionada.DataBind();
                //    }
                //    catch (Exception ex)
                //    {

                //        ExibirMensagemErro("Erro ao adcionar autorizações!:" + ex.Message);
                //    }
                //}

                //protected void btnretornar_Click(object sender, EventArgs e)
                //{
                //    try
                //    {
                //        List<Autorizacao> lstAutoPessoas = (List<Autorizacao>)Session["AutorizacoesPessoas"];
                //        List<Autorizacao> lstAuto = (List<Autorizacao>)Session["Autorizacoes"];

                //        for (int i = 0; i < grvautorizacaoselecionada.Rows.Count; i++)
                //        {
                //            CheckBox ck = (CheckBox)grvautorizacaoselecionada.Rows[i].FindControl("ckSelecionar");
                //            if (ck.Checked == true)
                //            {
                //                Autorizacao aut = new Autorizacao();
                //                aut.cmpAUTHID = grvautorizacaoselecionada.DataKeys[i][0].ToString();
                //                aut.SHORTNAME = grvautorizacaoselecionada.DataKeys[i][1].ToString();
                //                lstAuto.Add(aut);
                //                //lstAutoPessoas.Remove(lstAutoPessoas[i]);
                //            }
                //        }

                //        foreach (Autorizacao item in lstAuto)
                //        {
                //            Autorizacao aut = lstAutoPessoas.Find(x => x.cmpAUTHID == item.cmpAUTHID);

                //            lstAutoPessoas.Remove(aut);
                //        }

                //        Session["AutorizacoesPessoas"] = lstAutoPessoas;
                //        Session["Autorizacoes"] = lstAuto;

                //        grvautorizacoes.DataSource = lstAuto;
                //        grvautorizacoes.DataBind();

                //        grvautorizacaoselecionada.DataSource = lstAutoPessoas;
                //        grvautorizacaoselecionada.DataBind();
                //    }
                //    catch (Exception ex)
                //    {
                //        ExibirMensagemErro("Erro ao retirar autorização!:" + ex.Message);
                //    }
                //}

                //protected void btnsalvar_Click(object sender, ImageClickEventArgs e)
                //{
                //    try
                //    {
                //        if (VerificarCampos()==true )
                //        {
                //            tblPERSONS tblPerson=new tblPERSONS();;
                //            if (Session["idPerson"] != null)
                //            {
                //                tblPerson = new tblPERSONS(Global.GetConnection(), Session["idPerson"].ToString(), Session["PersID"].ToString(), Session["Origem"].ToString());

                //            }
                //            else
                //            {
                //                if (ExisteVisitante() == false)
                //                {
                //                    tblPerson = new tblPERSONS();
                //                }

                //            }

                //            string[] nome = txtNome.Text.Split(' ');
                //            tblPerson.cmpFIRSTNAME = nome[0];
                //            tblPerson.cmpLASTNAME = txtNome.Text.Substring(nome[0].Length, txtNome.Text.Length - nome[0].Length);
                //            tblPerson.cmpDATEOFBIRTH = txtnascimento.Text.Replace("/","");
                //            tblPerson.cmpPASSPORTNO = txtCpf.Text.Replace(".", "");
                //            tblPerson.cmpPASSPORTNO = tblPerson.cmpPASSPORTNO.Replace("-", "");
                //            tblPerson.cmpIDNUMBER = txtRG.Text;
                //            tblPerson.cmpPHONEOFFICE = txtTelFixo.Text;
                //            tblPerson.cmpPHONEMOBILE = txtTelCelular.Text;
                //            tblPerson.cmpEMAIL = txtemail.Text;
                //            tblPerson.cmpNUMBERPLATE = txtplaca.Text;
                //            tblPerson.cmpRESERVE2 = txtmarca.Text;
                //            tblPerson.cmpRESERVE3 = txtmodelo.Text;

                //            tblPerson.cmpCOMPANYID = ddlempresa.SelectedValue;
                //            tblPerson.cmpPERSCLASSID = ddltipovisitante.SelectedValue;
                //            tblPerson.cmpREASON = ddlmotivodavisita.Text;
                //            tblPerson.cmpAutoPERSID = Session["cmpAutoPERSID"].ToString();

                //            string retorno = tblPerson.Save(Global.GetConnection());
                //            if (retorno != "0") { tblPerson.cmpIDPERSON = retorno; }

                //            tblAUTHPERPERSON.Excluir(Global.GetConnection(), tblPerson.cmpIDPERSON);

                //            for (int i = 0; i < grvautorizacaoselecionada.Rows.Count; i++)
                //            {
                //                CheckBox ck = (CheckBox)grvautorizacaoselecionada.Rows[i].FindControl("ckSelecionar");
                //                tblAUTHPERPERSON tblAut = new tblAUTHPERPERSON();
                //                tblAut.cmpAUTHID = grvautorizacaoselecionada.DataKeys[i][0].ToString();
                //                tblAut.cmpIDPERSON = int.Parse(tblPerson.cmpIDPERSON);
                //                tblAut.cmpVALIDFROM = DateTime.Parse(txtdatainicio.Text);
                //                tblAut.cmpVALIDUNTIL = DateTime.Parse(txtdatafim.Text);
                //                tblAut.Save(Global.GetConnection());
                //            }

                //            Site master = (Site)this.Master;
                //            master.Mensagem("O registro foi salvo com sucesso!", ProjetoWebSolar.Site.TipoMensagem.Informacao, "webConsultaVisitante.aspx"); 
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        ExibirMensagemErro("Erro ao Salvar!:" +  ex.Message);
                //    }


                //}
                //private bool ExisteVisitante()
                //{
                //    try
                //    {
                //        string cpf = txtCpf.Text.Replace(".", "");
                //        cpf = cpf.Replace("-", "");
                //        bool existSQL = tblPERSONS.ExisteVisitante(Global.GetConnection(), cpf);
                //        if (existSQL == true) { throw new Exception("Já existe um visitante com este CPF no pré-cadastro!"); }
                //        bool existBis = (hzLibSolar.BIS.Persons.ExisteVisitante(Global.GetConnection(), cpf));
                //        if (existBis == true) { throw new Exception("Já existe um visitante com este CPF no BIS!"); }
                //        return false;
                //    }
                //    catch (Exception ex)
                //    {

                //        throw new Exception(ex.Message);
                //    }

                //}
                //private bool VerificarCampos()
                //{
                //    string mensagem="";

                //    if (string.IsNullOrEmpty(txtNome.Text) == true) 
                //    { 
                //        mensagem = "O campo Nome deve ser preenchido!";
                //    }
                //    if (string.IsNullOrEmpty(txtNome.Text) == false && txtNome.Text.Split(' ').Length==1)
                //    {
                //        mensagem = "O campo Nome e Sobrenome devem ser preenchidos!";
                //    }
                //    if (string.IsNullOrEmpty(txtCpf.Text) == true)
                //    {
                //        mensagem = "O campo CPF deve ser preenchido!";
                //    }
                //    else
                //    {
                //        bool valid = validarCPF(txtCpf.Text);
                //        if (valid == false) { mensagem = "O CPF está incorreto!"; }
                //    }
                //    if (string.IsNullOrEmpty(txtnascimento.Text) == true)
                //    {
                //        mensagem = "O campo Nascimento deve ser preenchido!";
                //    }
                //    if (string.IsNullOrEmpty(txtnascimento.Text) == false)
                //    {
                //        DateTime data;
                //        if (DateTime.TryParse(txtnascimento.Text, out data) == false)
                //        {
                //            mensagem = "Data inválida!";
                //        }
                //        if (data != null && data.Year >= DateTime.Now.Year)
                //        {
                //            mensagem = "Insira uma data válida!";
                //        }
                //    }
                //    if (grvautorizacaoselecionada.Rows.Count == 0)
                //    {
                //        mensagem = "Favor selecionar alguma autorização!";
                //    }

                //    DateTime dtInicio = DateTime.Parse(txtdatainicio.Text);
                //    DateTime dtFim = DateTime.Parse(txtdatafim.Text);

                //    if (dtInicio.Date < DateTime.Now.Date)
                //    {
                //        mensagem = "A data de início não pode ser menor que da data de hoje!";
                //    }
                //    if (dtInicio > dtFim)
                //    {
                //        mensagem = "A data de Fim não pode ser menor que da de Início!";
                //    }
                //    if (mensagem != "")
                //    {
                //        ExibirMensagemErro(mensagem);
                //        return false;
                //    }
                //    else
                //    {
                //        return true;
                //    }

                //}
                //public static bool validarCPF(string CPF)
                //{
                //    int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                //    int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                //    string TempCPF;
                //    string Digito;
                //    int soma;
                //    int resto;

                //    CPF = CPF.Trim();
                //    CPF = CPF.Replace(".", "").Replace("-", "");

                //    if (CPF.Length != 11)
                //        return false;

                //    TempCPF = CPF.Substring(0, 9);
                //    soma = 0;
                //    for (int i = 0; i < 9; i++)
                //        soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

                //    resto = soma % 11;
                //    if (resto < 2)
                //        resto = 0;
                //    else
                //        resto = 11 - resto;

                //    Digito = resto.ToString();
                //    TempCPF = TempCPF + Digito;
                //    soma = 0;

                //    for (int i = 0; i < 10; i++)
                //        soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

                //    resto = soma % 11;
                //    if (resto < 2)
                //        resto = 0;
                //    else
                //        resto = 11 - resto;

                //    Digito = Digito + resto.ToString();

                //    return CPF.EndsWith(Digito);
                //}
                //protected void btnFecharMensagem_Click(object sender, EventArgs e)
                //{

                //}

                //protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
                //{

                //}

                //protected void rblTipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
                //{
                //    CarregarTipoVisitante();
                //}
                //private void CarregarTipoVisitante()
                //{
                //    ddltipovisitante.Items.Clear();

                //    DataTable dtTipov = hzLibSolar.BIS.PERSCLASSES.GET(Global.GetConnection());
                //    for (int i = 0; i < dtTipov.Rows.Count; i++)
                //    {

                //            if ( dtTipov.Rows[i]["ISDISABLED"].ToString() == "0" && string.IsNullOrEmpty(dtTipov.Rows[i]["DATEDELETED"].ToString()) == true)
                //            {
                //                ddltipovisitante.Items.Add(new ListItem(dtTipov.Rows[i]["displaytextcustomer"].ToString(), dtTipov.Rows[i]["PERSCLASSID"].ToString()));
                //            }

            }
        }

    }
}