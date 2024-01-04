using Calculator.MVVM.ViewModels;

namespace Calculator.MVVM;

public partial class CalcView : ContentPage
{
    public CalcView()
    {
        InitializeComponent();
        BindingContext = new CalcViewModel();
    }
}