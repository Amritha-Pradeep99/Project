using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnadd_Click(object sender, EventArgs e)
    {
        TableRow Trow = new TableRow();

        TableCell rollnocell=new TableCell();
        rollnocell.Text = txtrn.Text;
        Trow.Cells.Add(rollnocell);

        TableCell namecell = new TableCell();
        namecell.Text = txtname.Text;
        Trow.Cells.Add(namecell);

        TableCell markcell = new TableCell();
        markcell.Text = txtmark.Text;
        Trow.Cells.Add(markcell);

        Table1.Rows.Add(Trow);
    }
}