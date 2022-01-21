import { Component, OnInit, Inject, Injectable } from '@angular/core';
import { Cliente } from 'src/app/models/cliente';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProfissaoService } from 'src/app/services/profissao.service';
import { Profissao } from 'src/app/models/profissao';

@Component({
  selector: 'app-cliente-dialog',
  templateUrl: './cliente-dialog.component.html',
  styleUrls: ['./cliente-dialog.component.scss']
})
export class ClienteDialogComponent implements OnInit {
  cliente!: Cliente;
  isChange!: boolean;
  profissoes!: Profissao[];

  constructor(
    public dialogRef: MatDialogRef<ClienteDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Cliente,
  ) {}

  ngOnInit(): void {
    if (this.data.id !== null) {
      this.isChange = true;
    } else {
      this.isChange = false;
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
