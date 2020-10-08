import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product.model';
import { AttendanceService } from '../services/attendance/attendance.service';
import { ProductService } from '../services/product/product.service';

@Component({
  selector: 'app-form-fields',
  templateUrl: './form-fields.component.html',
  styleUrls: ['./form-fields.component.scss']
})
export class FormFieldsComponent implements OnInit {

  products: Product[] = [];

  constructor(
    private attendanceService: AttendanceService,
    private productService: ProductService
  ) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getAttendanceByProductId(event): void {
    console.log(event);
    this.attendanceService.getAttendanceByProductId(event.id).subscribe(response => {
      console.log(response);
    });
  }

  getProducts(): void {
    this.productService.getProducts().subscribe(response => {
      this.products = response;
    });
  }

  selected(): void {
    console.log('Value Changed');
  }

}
