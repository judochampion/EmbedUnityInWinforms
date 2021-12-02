using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Container
{
	class SelectablePanel : Panel
	{
		public SelectablePanel()
		{
			this.SetStyle(ControlStyles.Selectable, true);
			this.TabStop = true;
		}

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
    }
}
