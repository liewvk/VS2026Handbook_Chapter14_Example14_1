using System;
using System.Drawing;
using System.Windows.Forms;
using VS2026Handbook_Chapter14_Example14_1;
ApplicationConfiguration.Initialize();
var form = new Form { Text = "Invoice Calculator", ClientSize = new Size(370, 180) };
var price = new TextBox { Left = 15, Top = 20, Width = 100, Text = "25" };
var qty = new TextBox { Left = 130, Top = 20, Width = 100, Text = "3" };
var result = new Label { Left = 15, Top = 100, Width = 330, Text = "Enter values and calculate" };
var button = new Button { Left = 15, Top = 60, Width = 110, Text = "Calculate" };
button.Click += (_, _) =>
{
    if (decimal.TryParse(price.Text, out var p) && int.TryParse(qty.Text, out var q))
        result.Text = $"Total: RM{p * q:F2}";
    else result.Text = "Enter valid numbers.";
};
form.Controls.AddRange(new Control[] { price, qty, button, result });
Application.Run(form);
