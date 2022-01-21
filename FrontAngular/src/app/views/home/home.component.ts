import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTable } from '@angular/material/table';
import { Cliente } from 'src/app/models/cliente';
import { ClienteService } from 'src/app/services/cliente.service';
import { ClienteDialogComponent } from 'src/app/shared/cliente-dialog/cliente-dialog.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  providers: [ClienteService]
})
export class HomeComponent implements OnInit {
  @ViewChild(MatTable)
  table!: MatTable<any>;
  displayedColumns: string[] = ['nome', 'sobrenome', 'cpf', 'dataNascimento', 'idade', 'profissao', 'action'];
  dataSource!: Cliente[];
  
  constructor(
    public dialog: MatDialog,
    public clienteService: ClienteService) 
    {
      this.getCliente();
    }

  ngOnInit(): void {
  }

  openDialog(cliente: Cliente | null): void {
    const dialogRef = this.dialog.open(ClienteDialogComponent, {
      width: '250px',
      data: cliente === null ? {
        id: null,
        nome: null, 
        sobrenome: null,
        cpf: null,
        idade: null, 
        dataNascimento: null, 
        profissaoId: null, 
        profissao: undefined
      } : cliente,
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result !== undefined) {
        this.editCliente(result);
      }
    });
  }

  getCliente(): void {
    this.clienteService.getCliente()
      .subscribe((data: Cliente[]) => {
        this.dataSource = data;
      })
  }

  deleteCliente(idCliente: number): void {
    this.clienteService.deleteCliente(idCliente)
      .subscribe(() => {
        this.getCliente();
      });
  }

  editCliente(cliente: Cliente): void {
    this.clienteService.editCliente(cliente)
          .subscribe((data:  Cliente) => {
            this.getCliente();
          })
  }

}
