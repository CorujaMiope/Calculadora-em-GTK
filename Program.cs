using Gtk;
using ImageMagick;
using Pango;
using WebKit;

class SharpApp : Window
{
    static Entry txtbox = new();

    static decimal valor1 { get; set; }
    static decimal valor2 { get; set; }

    static char? operadores;
    public SharpApp() : base("Center")
    {
        Button btn0 = new("0");
        Button btn1 = new("1");
        Button btn2 = new("2");
        Button btn3 = new("3");
        Button btn4 = new("4");
        Button btn5 = new("5");
        Button btn6 = new("6");
        Button btn7 = new("7");
        Button btn8 = new("8");
        Button btn9 = new("9");
        Button btnSoma = new("+");
        Button btnSub = new("-");
        Button btnMult = new("x");
        Button btnDiv = new("/");
        Button btnResult = new("=");
        Button btnLimpar = new("C");
        Label titulo = new();


        Fixed @fixed = new();

        SetDefaultSize(300, 300);
        SetPosition(WindowPosition.Center);
        SetIconFromFile("C:\\Users\\Dell\\OneDrive\\Área de Trabalho\\projeto raimon\\icones/exit.png");
        Image img = new Image("C:\\Users\\Dell\\OneDrive\\Área de Trabalho\\Projetos\\superMario/fundo calculadora mario.png");


        DeleteEvent += delegate { Application.Quit(); };

        titulo.Markup = "<span foreground='green' font_weight='bold' font_desc = 'Comic Sans 10'>Calculadora</span>";

        txtbox.Sensitive = false;
        btn0.Sensitive = true;
        btn1.Sensitive = true;
        btn2.Sensitive = true;
        btn3.Sensitive = true;
        btn4.Sensitive = true;
        btn5.Sensitive = true;
        btn6.Sensitive = true;
        btn7.Sensitive = true;
        btn8.Sensitive = true;
        btn9.Sensitive = true;
        btnSoma.Sensitive = true;
        btnSub.Sensitive = true;
        btnMult.Sensitive = true;
        btnDiv.Sensitive = true;
        btnResult.Sensitive = true;
        btnLimpar.Sensitive = true;


        txtbox.SetSizeRequest(195, 40);
        btn0.SetSizeRequest(10, 10);
        btn1.SetSizeRequest(10, 10);
        btn2.SetSizeRequest(10, 10);
        btn3.SetSizeRequest(10, 10);
        btn4.SetSizeRequest(10, 10);
        btn5.SetSizeRequest(10, 10);
        btn6.SetSizeRequest(10, 10);
        btn7.SetSizeRequest(10, 10);
        btn8.SetSizeRequest(10, 10);
        btn9.SetSizeRequest(10, 10);
        btnSoma.SetSizeRequest(10, 10);
        btnMult.SetSizeRequest(10, 10);
        btnSub.SetSizeRequest(10, 10);
        btnDiv.SetSizeRequest(10, 10);
        btnResult.SetSizeRequest(10, 10);
        btnLimpar.SetSizeRequest(10, 10);

        @fixed.Put(img, 0, 0);
        @fixed.Put(titulo, 80, 100);
        @fixed.SetSizeRequest(10, 10);
        @fixed.Put(txtbox, 25, 120);
        @fixed.Put(btn1, 20, 250);
        @fixed.Put(btn2, 75, 250);
        @fixed.Put(btn3, 130, 250);
        @fixed.Put(btn4, 20, 210);
        @fixed.Put(btn5, 75, 210);
        @fixed.Put(btn6, 130, 210);
        @fixed.Put(btn7, 20, 170);
        @fixed.Put(btn8, 75, 170);
        @fixed.Put(btn9, 130, 170);
        @fixed.Put(btn0, 185, 170);
        @fixed.Put(btnSoma, 185, 250);
        @fixed.Put(btnResult, 240, 250);
        @fixed.Put(btnMult, 185, 210);
        @fixed.Put(btnSub, 240, 210);
        @fixed.Put(btnDiv, 240, 170);
        @fixed.Put(btnLimpar, 240, 130);

        @fixed.Put(titulo, 100, 10);

        btn1.Clicked += OnButtonClicked;
        btn2.Clicked += OnButtonClicked2;
        btn3.Clicked += OnButtonClicked3;
        btn4.Clicked += OnButtonClicked4;
        btn5.Clicked += OnButtonClicked5;
        btn6.Clicked += OnButtonClicked6;
        btn7.Clicked += OnButtonClicked7;
        btn8.Clicked += OnButtonClicked8;
        btn9.Clicked += OnButtonClicked9;
        btn0.Clicked += OnButtonClicked0;

        btnSoma.Clicked += OnButtonClickedSoma;
        btnSub.Clicked += OnButtonClickedSub;
        btnMult.Clicked += OnButtonClickedMult;
        btnDiv.Clicked += OnButtonClickedDiv;
        btnLimpar.Clicked += OnButtonClickedLimpar;
        btnResult.Clicked += OnButtonClickedResult;

        Add(@fixed);
        ShowAll();
    }

    public static void Main()
    {
        Application.Init();
        new SharpApp();
        Application.Run();
    }

    private static void OnButtonClicked(object? sender, EventArgs e)
    {
        txtbox.Text += "1";
    }

    private static void OnButtonClicked2(object? sender, EventArgs e)
    {
        txtbox.Text += "2";
    }

    private static void OnButtonClicked3(object? sender, EventArgs e)
    {
        txtbox.Text += "3";
    }

    private static void OnButtonClicked4(object? sender, EventArgs e)
    {
        txtbox.Text += "4";
    }

    private static void OnButtonClicked5(object? sender, EventArgs e)
    {
        txtbox.Text += "5";
    }

    private static void OnButtonClicked6(object? sender, EventArgs e)
    {
        txtbox.Text += "6";
    }

    private static void OnButtonClicked7(object? sender, EventArgs e)
    {
        txtbox.Text += "7";
    }

    private static void OnButtonClicked8(object? sender, EventArgs e)
    {
        txtbox.Text += "8";
    }

    private static void OnButtonClicked9(object? sender, EventArgs e)
    {
        txtbox.Text += "9";
    }

    private static void OnButtonClicked0(object? sender, EventArgs e)
    {
        txtbox.Text += "0";
    }

    private static void OnButtonClickedSoma(object? sender, EventArgs e)
    {
        try
        {
            valor1 = decimal.Parse(txtbox.Text);
            operadores = '+';
            txtbox.Text += operadores;
        }
        catch { MenssagemDeErro(0); }
        
    }

    private static void OnButtonClickedSub(object? sender, EventArgs e)
    {
        try
        {
            valor1 = decimal.Parse(txtbox.Text);
            operadores = '-';
            txtbox.Text += operadores;

        }catch { MenssagemDeErro(0); }
       
    }

    private static void OnButtonClickedMult(object? sender, EventArgs e)
    {
        try
        {
            valor1 = decimal.Parse(txtbox.Text);
            operadores = 'x';
            txtbox.Text += operadores;

        }catch { MenssagemDeErro(0); }
        
    }

    private static void OnButtonClickedDiv(object? sender, EventArgs e)
    {
        try
        {
            valor1 = decimal.Parse(txtbox.Text);
            operadores = '/';
            txtbox.Text += operadores;

        }catch { MenssagemDeErro(0); }
        
        
    }

    private static void OnButtonClickedLimpar(object? sender, EventArgs e)
    {
        txtbox.Text = string.Empty;
    }

    private static void OnButtonClickedResult(object? sender, EventArgs e)
    {
        try
        {
            string[] dividir;
            dividir = txtbox.Text.Split(Convert.ToChar(operadores));
            valor2 = decimal.Parse(dividir[1]);

        }catch { MenssagemDeErro(1); }
       

        switch (operadores)
        {
            case '+':
                txtbox.Text = $"{Calculo(valor1, Convert.ToChar(operadores), valor2)}";

                break;


            case '-':
                txtbox.Text = $"{Calculo(valor1, Convert.ToChar(operadores), valor2)}";

                break;


            case 'x':
                txtbox.Text = $"{Calculo(valor1, Convert.ToChar(operadores), valor2)}";

                break;


            case '/':
                txtbox.Text = $"{Calculo(valor1, Convert.ToChar(operadores), valor2)}";

                break;
        }

    }

    static decimal Calculo(decimal valor1, char operador, decimal valor2)
    {
        try
        {
            if (operador == '+')
                return valor1 + valor2;

            if (operador == '-')
                return valor1 - valor2;

            if (operador == 'x')
                return valor1 * valor2;

            else return valor1 / valor2;

        }catch {throw; }

       
    }

    static void MenssagemDeErro(int CodigooDoErro)
    {
        
        if(CodigooDoErro == 0)
            txtbox.Text = "Digite apenas um operador";

        if (CodigooDoErro == 1)
            txtbox.Text = "Caixa vazia";

        //Thread.Sleep(2000);
        //txtbox.Text = string.Empty;
    }

    
}
