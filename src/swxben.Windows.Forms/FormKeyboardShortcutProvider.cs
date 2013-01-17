using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace swxben.Windows.Forms
{
    public class FormKeyboardShortcutProvider
    {
        public class Handler
        {
            public Keys Keys { get; set; }
            public Action Callback { get; set; }
        }

        public List<Handler> Handlers { get; private set; }

        public FormKeyboardShortcutProvider(Form form)
        {
            form.KeyPreview = true;
            form.KeyDown += form_KeyDown;
            Handlers = new List<Handler>();
        }

        void form_KeyDown(object sender, KeyEventArgs args)
        {
            Handlers
                .Where(h => h.Keys == args.KeyData)
                .ToList()
                .ForEach(h => h.Callback());
        }
    }
}
