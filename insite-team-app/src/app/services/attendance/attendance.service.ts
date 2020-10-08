import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Attendance } from '../../models/attendance.model';

@Injectable({
  providedIn: 'root'
})
export class AttendanceService {

  private baseUrl = 'http://localhost:5000/api/attendance/';

  constructor(private http: HttpClient) { }

  getAttendanceByProductId(id: string): Observable<Attendance[]> {
    return this.http.get<Attendance[]>(this.baseUrl + 'product/' + id);
  }

  getAttendanceBySeasonIdAndGameId(seasonId: number, gameId: number): Observable<Attendance[]> {
    return this.http.get<Attendance[]>(this.baseUrl + 'season/' + seasonId + '/game/' + gameId);
  }
}
