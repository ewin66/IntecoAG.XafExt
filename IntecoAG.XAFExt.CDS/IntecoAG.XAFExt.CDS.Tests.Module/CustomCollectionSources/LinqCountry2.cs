﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;

namespace IntecoAG.XAFExt.CDS.Tests 
{
    public class LinqQueryCountry2 : LinqQuery<testCountry2, testCountry>
    {
        public LinqQueryCountry2(Session ses)
            : base(ses) {
        }

        public override IQueryable<testCountry2> GetQuery() {
            var queryCore = from item in Provider
                        select new testCountry2 {
                            Name = item.NameShort + " (" + item.NameFull + ")"
                        };
            return queryCore;
        }
    }
}