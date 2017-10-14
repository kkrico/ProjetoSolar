using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWebSolar
{
    public partial class Webformulariovisitante2 : System.Web.UI.Page
    {
        public struct Autorizacao
        {
            public string Nome { get; set; }
            public string Local {get;set;}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Autorizacao> lstAutorizacao = new List<Autorizacao>();
            Autorizacao auto = new Autorizacao();
            auto.Nome = "Refeitorio";
            auto.Local = "SUAPE";
            lstAutorizacao.Add(auto);

            auto = new Autorizacao();
            auto.Nome = "Visitante";
            auto.Local = "SUAPE1";
            lstAutorizacao.Add(auto);

            grvautorizacoes.DataSource = lstAutorizacao;
            grvautorizacoes.DataBind();

            lstAutorizacao.Clear();

            auto = new Autorizacao();
            auto.Nome = "Visitante";
            auto.Local = "SUAPE1";
            lstAutorizacao.Add(auto);

            auto = new Autorizacao();
            auto.Nome = "Visitante";
            auto.Local = "SUAPE1";
            lstAutorizacao.Add(auto);



        }

        protected void grvautorizacaoselecionada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}