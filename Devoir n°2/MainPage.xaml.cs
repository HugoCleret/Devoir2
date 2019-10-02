using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ModelMetier;
using Windows.UI.Popups;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Devoir_n_2
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        Dictionary<string, List<ActionAchetee>> dico = new Dictionary<string, List<ActionAchetee>>();
        List<ActionReelle> lesActionsReelles = new List<ActionReelle>();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dico.Add
            ("Enzo", new List<ActionAchetee>()
            {
                new ActionAchetee()
                {
                    CodeAction = "AAPL",
                    NomAction = "Apple",
                    ValeurAction = 200,
                    PrixAchat = 210,
                    Quantite = 10
                },
                new ActionAchetee()
                {
                    CodeAction = "MSFT",
                    NomAction = "Microsoft",
                    ValeurAction = 140,
                    PrixAchat = 100,
                    Quantite = 50
                },
                new ActionAchetee()
                {
                    CodeAction = "TWTR",
                    NomAction = "Twitter",
                    ValeurAction = 40,
                    PrixAchat = 35,
                    Quantite = 20
                },
                new ActionAchetee()
                {
                    CodeAction = "IBM",
                    NomAction = "International Business Machines",
                    ValeurAction = 140,
                    PrixAchat = 110,
                    Quantite = 40
                }
            }
            );
            dico.Add
            ("Noa", new List<ActionAchetee>()
                {
                new ActionAchetee()
                {
                    CodeAction = "FB",
                    NomAction = "Facebook",
                    ValeurAction = 180,
                    PrixAchat = 210,
                    Quantite = 10
                },
                new ActionAchetee()
                {
                    CodeAction = "AXA",
                    NomAction = "Axa assurances",
                    ValeurAction = 25,
                    PrixAchat = 15,
                    Quantite = 20
                },
                new ActionAchetee()
                {
                    CodeAction = "SAP",
                    NomAction = "SAP SE",
                    ValeurAction = 120,
                    PrixAchat = 100,
                    Quantite = 30
                }
            }
            );
            dico.Add
            ("Lilou", new List<ActionAchetee>()
                {
                new ActionAchetee()
                {
                    CodeAction = "TWTR",
                    NomAction = "Twitter",
                    ValeurAction = 40,
                    PrixAchat = 25,
                    Quantite = 50
                },
                new ActionAchetee()
                {
                    CodeAction = "INTC",
                    NomAction = "Intel Corporation",
                    ValeurAction = 50,
                    PrixAchat = 35,
                    Quantite = 15
                },
                new ActionAchetee()
                {
                    CodeAction = "VMW",
                    NomAction = "VMware",
                    ValeurAction = 145,
                    PrixAchat = 150,
                    Quantite = 30
                },
                new ActionAchetee()
                {
                    CodeAction = "TXN",
                    NomAction = "Texas Instrument Incorporated",
                    ValeurAction = 130,
                    PrixAchat = 140,
                    Quantite = 25
                }
            }
            );
            lesActionsReelles.Add
           (
               new ActionReelle()
               {
                   CodeAction = "AAPL",
                   NomAction = "Apple",
                   ValeurAction = 200
               }
           );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "MSFT",
                    NomAction = "Microsoft",
                    ValeurAction = 14
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "TWTR",
                    NomAction = "Twitter",
                    ValeurAction = 40
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "IBM",
                    NomAction = "International Business Machines",
                    ValeurAction = 140
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "FB",
                    NomAction = "Facebook",
                    ValeurAction = 180
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "AXA",
                    NomAction = "Axa assurances",
                    ValeurAction = 25
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "SAP",
                    NomAction = "SAP SE",
                    ValeurAction = 120
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "INTC",
                    NomAction = "Intel Corporation",
                    ValeurAction = 50
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "VMW",
                    NomAction = "VMware",
                    ValeurAction = 145
                }
            );
            lesActionsReelles.Add
            (
                new ActionReelle()
                {
                    CodeAction = "TXN",
                    NomAction = "Texas Instrument Incorporated",
                    ValeurAction = 130
                }
            );
            lvTrades.ItemsSource = dico.Keys;


            lvAchat.ItemsSource = lesActionsReelles;
        }

        private void LvTrades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvTrades.SelectedItem != null)
            {
                lvActions.ItemsSource = dico[lvTrades.SelectedItem.ToString()];
            }
            double d = 0;
             
            foreach(ActionAchetee a in dico[lvTrades.SelectedItem.ToString()])
            {
                d = d+ (a.Quantite * a.PrixAchat);
            }
            txtPortefeuille.Text = d.ToString();
        }

        private void LvAchat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void LvActions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNomAction.Text = (lvActions.SelectedItem as ActionAchetee).NomAction;
            txtValeurAction.Text = (lvActions.SelectedItem as ActionAchetee).ValeurAction.ToString();
            txtPrixAchat.Text= (lvActions.SelectedItem as ActionAchetee).PrixAchat.ToString();
            txtQuantiteAchetee.Text = (lvActions.SelectedItem as ActionAchetee).Quantite.ToString();
        }

        private void BtnAcheter_Click(object sender, RoutedEventArgs e)
        {
            if(lvAchat.SelectedItem == null)
            {
                var dialog = new MessageDialog("Selectionner une action");
                if (txtPrixAcheter.Text == "")
                {
                    var dialog1 = new MessageDialog("Saisir le prix d'achat");

                    if (txtQuantiteAchat.Text == "")
                    {
                        var dialog2 = new MessageDialog("Saisir la quantité");
                    }
                    //else
                    //{
                    //    lesActionsReelles.Add
                    //        (
                    //            new ActionAchetee()
                    //            {
                    //                CodeAction = (lvAchat.SelectedItem as ActionReelle).CodeAction,
                    //                NomAction = (lvAchat.SelectedItem as ActionReelle).NomAction,
                    //                ValeurAction = (lvAchat.SelectedItem as ActionReelle).ValeurAction
                    //            }
                    //        ); 

                    //    dico[lvTrades.SelectedItem.ToString()].Add(ActionReelle = new ActionAchetee)
                        
                    //}
                }
            }
        }
    }
}
