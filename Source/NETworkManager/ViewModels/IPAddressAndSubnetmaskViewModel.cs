﻿using NETworkManager.Utilities;
using System;
using System.Windows.Input;

namespace NETworkManager.ViewModels;

public class IPAddressAndSubnetmaskViewModel : ViewModelBase
{
    public ICommand OKCommand { get; }

    public ICommand CancelCommand { get; }

    private string _ipAddress;
    public string IPAddress
    {
        get => _ipAddress;
        set
        {
            if (value == _ipAddress)
                return;

            _ipAddress = value;
            OnPropertyChanged();
        }
    }

    private string _subnetmask;
    public string Subnetmask
    {
        get => _subnetmask;
        set
        {
            if (value == _subnetmask)
                return;

            _subnetmask = value;
            OnPropertyChanged();
        }
    }

    public IPAddressAndSubnetmaskViewModel(Action<IPAddressAndSubnetmaskViewModel> okCommand, Action<IPAddressAndSubnetmaskViewModel> cancelHandler)
    {
        OKCommand = new RelayCommand(p => okCommand(this));
        CancelCommand = new RelayCommand(p => cancelHandler(this));
    }        
}