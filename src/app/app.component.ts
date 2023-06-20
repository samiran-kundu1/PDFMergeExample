import { Component, ElementRef, ViewChild } from '@angular/core';

declare var require: any;

 import * as pdfMake from "pdfmake/build/pdfmake";
 import * as pdfFonts from "pdfmake/build/vfs_fonts";
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;

import jsPDF from 'jspdf';
import { HttpClient } from '@angular/common/http';
//import pdfMake from 'pdfmake/build/pdfmake';
//import pdfFonts from 'pdfmake/build/vfs_fonts';
//pdfMake.vfs = pdfFonts.pdfMake.vfs;
//import htmlToPdfmake from 'html-to-pdfmake';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  @ViewChild('pdftable') public pdfTable: ElementRef;
  
  constructor(private http: HttpClient) { }
  public exportPDF() {
    const doc = new jsPDF();
   
    const pdfTable = this.pdfTable.nativeElement;
   
    var html = htmlToPdfmake(pdfTable.innerHTML);
     
    const documentDefinition = { content: html };
    //pdfMake.createPdf(documentDefinition).open(); 
    pdfMake.createPdf(documentDefinition).download('testfileformerge.pdf'); 
    this.http.get('https://localhost:7022/api/PDFMerge').subscribe(data => {
      //this.postId = data.id;
  });
    //doc.save()
    
  }
}
