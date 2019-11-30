using NeoLosowanie.Models;
using NeoLosowanie.Repositories;
using NeoLosowanie.Services;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeoLosowanie.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManagePersonsPage : ContentPage
    {
        ViewModels.Pages.ManagePersonsPage vm;
        public ManagePersonsPage()
        {
            InitializeComponent();

            vm = new ViewModels.Pages.ManagePersonsPage();
            this.BindingContext = vm;
        }

        private void ifMarriage_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            vm.AddSupose = (sender as CheckBox).IsChecked;
        }

        private void btnAddPerson_Clicked(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                Person person = new Person();
                if (vm.AddedPerson != null)
                    person = vm.AddedPerson;
                person.CollectionId = SystemService.Collection.Id;
                person.FirstName = firstName.Text.Trim();
                person.LastName = lastName.Text.Trim();
                person.PhoneNumber = phoneNumber.Text.Trim();
                person.Email = email.Text.Trim();
                PersonRepository.Insert(person);
                dodanoOsobeLabel.Text = "Dodano osobę!";

                Person supose = null;

                if (ifMarriage.IsChecked)
                {
                    Debug.WriteLine("DUPA");
                    dodanoOsobeLabel.Text = "Dodano małżeństwo!";
                    if (switchAdd.IsToggled)
                    {
                        supose = marriagePicker.SelectedItem as Person;
                        if (supose.IsMarriage)
                        {
                            vm.AddedPerson = person;
                            DisplayAlert("Błąd!", "Wybrana osoba już jest w małżeństwie!", "OK");
                            return;
                        }
                        else
                        {
                            supose.IsMarriage = true;
                        }
                    }
                    else
                    {
                        supose = new Person();
                        supose.CollectionId = SystemService.Collection.Id;
                        supose.FirstName = firstNameSupose.Text.Trim();
                        supose.LastName = lastNameSupose.Text.Trim();
                        supose.PhoneNumber = phoneNumberSupose.Text.Trim();
                        supose.Email = emailSupose.Text.Trim();
                        supose.IsMarriage = true;
                    }
                    if (!MarriageRepository.Insert(new Marriage(person.Id, supose.Id)))
                    {
                        vm.AddedPerson = person;
                        DisplayAlert("Błąd!", "Wybrana osoba już jest w małżeństwie!", "OK");
                        return;
                    }
                    person.IsMarriage = true;
                    PersonRepository.Insert(supose);
                    PersonRepository.Insert(person);
                }
                
                
                firstName.Text = "";
                lastName.Text = "";
                phoneNumber.Text = "";
                email.Text = "";
                firstNameSupose.Text = "";
                lastNameSupose.Text = "";
                phoneNumberSupose.Text = "";
                emailSupose.Text = "";
                ifMarriage.IsChecked = false;
                switchAdd.IsToggled = true;
                marriagePicker.SelectedItem = null;
                vm.loadPersons();
                vm.AddedPerson = null;
            }
            else
            {
                DisplayAlert("Błąd", "Błędnie wypełnione pola!", "OK");
                return;
            }
            vm.AddedLabel = true;
            Task.Run(async () =>
            {
                Thread.Sleep(3000);
                vm.AddedLabel = false;
            });
        }

        private bool Validate()
        {
            if (lastName.Text == null || lastName.Text.Trim().Length == 0)
                return false;

            if (phoneNumber.Text != null && phoneNumber.Text.Trim().Length > 0)
            {
                if (!Regex.IsMatch(phoneNumber.Text.Trim(), "^[0-9]{9}$"))
                    return false;
            }

            if (email.Text != null && email.Text.Trim().Length > 0)
            {
                if (!Regex.IsMatch(email.Text.Trim().ToLower(), "^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,6}$"))
                    return false;
            }

            if (ifMarriage.IsChecked)
            {
                if (switchAdd.IsToggled)
                {
                    if (marriagePicker.SelectedItem == null)
                        return false;

                }
                else
                {
                    if (lastNameSupose.Text == null || lastNameSupose.Text.Trim().Length == 0)
                        return false;

                    if (phoneNumberSupose.Text != null && phoneNumberSupose.Text.Trim().Length > 0)
                    {
                        if (!Regex.IsMatch(phoneNumberSupose.Text.Trim(), "^[0-9]{9}$"))
                            return false;
                    }

                    if (emailSupose.Text != null && emailSupose.Text.Trim().Length > 0)
                    {
                        if (!Regex.IsMatch(emailSupose.Text.Trim().ToLower(), "^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,6}$"))
                            return false;
                    }
                }
            }
            return true;
        }

        private void importFile_Clicked(object sender, EventArgs e)
        {

        }

        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (switchAdd.IsToggled)
            {
                vm.AddExist = true;
                vm.SwitchText = "Wybierz z istniejących osób";
            }
            else
            {
                vm.AddExist = false;
                vm.SwitchText = "Dodaj nową osobę";
            }
        }

        private void ifMarriageStack_Tapped(object sender, EventArgs e)
        {
            ifMarriage.IsChecked = !ifMarriage.IsChecked;
        }

        private void switchStack_Tapped(object sender, EventArgs e)
        {
            switchAdd.IsToggled = !switchAdd.IsToggled;
        }
    }
}