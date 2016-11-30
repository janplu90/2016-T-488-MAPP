﻿using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.Model;

namespace HelloWorld.iOS.Controllers
{
    using UIKit;
    public class NameListController : UITableViewController
    {
        private List<Person> _personList;

        public NameListController(List<Person> personList)
        {
            this._personList = personList;
        }

        public override void ViewDidLoad()
        {
            this.View.BackgroundColor = UIColor.White;
            this.Title = "Name list";

            this.TableView.Source = new NameListSource(this._personList, OnSelectedPerson);
        }

        private void OnSelectedPerson(int row)
        {
            var okAlertController = UIAlertController.Create("Person selected", this._personList[row].Name, UIAlertControllerStyle.Alert);

            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            this.PresentViewController(okAlertController, true, null);
        }
    }
}
