using attendance.Models;
using attendance.Services;
using attendance.ViewModel;
using CommunityToolkit.Maui.Views;

namespace attendance.Views;


public partial class TransactionDetailsPopUp : Popup
{

    public TransactionDetailsPopUp(Transaction transaction)
    {
        InitializeComponent();
        TransactionDetailsPopUpViewModel viewModel = new TransactionDetailsPopUpViewModel(transaction, new TransactionService(), this);
        BindingContext = viewModel;
    }
    private void closepopup(object sender, EventArgs e)
    {
        Close();
    }

}