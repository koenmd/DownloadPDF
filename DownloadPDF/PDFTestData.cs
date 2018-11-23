using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DownloadPDF
{
    public class PDFTestData
    {

        public const string OneMonth = @"

    <table _ngcontent-c4="""" class=""table table-bordered"" id=""resultsTable"">
        <thead _ngcontent-c4="""">
            <tr _ngcontent-c4="""">
                <!----><th _ngcontent-c4="""">Nom</th>
                <!----><th _ngcontent-c4="""">Département</th>
                <!---->
                <!---->
                <!---->
                <!----><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">je</span>
                    <span _ngcontent-c4="""" class=""vertical"">1</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ve</span>
                    <span _ngcontent-c4="""" class=""vertical"">2</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">sa</span>
                    <span _ngcontent-c4="""" class=""vertical"">3</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">di</span>
                    <span _ngcontent-c4="""" class=""vertical"">4</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">lu</span>
                    <span _ngcontent-c4="""" class=""vertical"">5</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ma</span>
                    <span _ngcontent-c4="""" class=""vertical"">6</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">me</span>
                    <span _ngcontent-c4="""" class=""vertical"">7</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">je</span>
                    <span _ngcontent-c4="""" class=""vertical"">8</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ve</span>
                    <span _ngcontent-c4="""" class=""vertical"">9</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">sa</span>
                    <span _ngcontent-c4="""" class=""vertical"">10</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">di</span>
                    <span _ngcontent-c4="""" class=""vertical"">11</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">lu</span>
                    <span _ngcontent-c4="""" class=""vertical"">12</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ma</span>
                    <span _ngcontent-c4="""" class=""vertical"">13</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">me</span>
                    <span _ngcontent-c4="""" class=""vertical"">14</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">je</span>
                    <span _ngcontent-c4="""" class=""vertical"">15</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ve</span>
                    <span _ngcontent-c4="""" class=""vertical"">16</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">sa</span>
                    <span _ngcontent-c4="""" class=""vertical"">17</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">di</span>
                    <span _ngcontent-c4="""" class=""vertical"">18</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">lu</span>
                    <span _ngcontent-c4="""" class=""vertical"">19</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ma</span>
                    <span _ngcontent-c4="""" class=""vertical"">20</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">me</span>
                    <span _ngcontent-c4="""" class=""vertical"">21</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">je</span>
                    <span _ngcontent-c4="""" class=""vertical"">22</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ve</span>
                    <span _ngcontent-c4="""" class=""vertical"">23</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">sa</span>
                    <span _ngcontent-c4="""" class=""vertical"">24</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">di</span>
                    <span _ngcontent-c4="""" class=""vertical"">25</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">lu</span>
                    <span _ngcontent-c4="""" class=""vertical"">26</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ma</span>
                    <span _ngcontent-c4="""" class=""vertical"">27</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">me</span>
                    <span _ngcontent-c4="""" class=""vertical"">28</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">je</span>
                    <span _ngcontent-c4="""" class=""vertical"">29</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ve</span>
                    <span _ngcontent-c4="""" class=""vertical"">30</span>
                </th>
            </tr>
        </thead>
        <tbody _ngcontent-c4="""">
            <!----><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">AGOZZINO sgo (tst) FRANCES</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: linear-gradient(to right, rgb(188, 143, 143) 33.33%, rgb(255, 192, 203) 33.33%, rgb(255, 192, 203) 66.66%, rgb(188, 143, 143) 66.66%); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">1</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: linear-gradient(to right, rgb(188, 143, 143) 33.33%, rgb(176, 196, 222) 33.33%, rgb(176, 196, 222) 66.66%, rgb(188, 143, 143) 66.66%); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: linear-gradient(to right, rgb(188, 143, 143) 33.33%, rgb(255, 192, 203) 33.33%, rgb(255, 192, 203) 66.66%, rgb(188, 143, 143) 66.66%); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ALAIMO DAVID</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">AMARA AHMED</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Expédition</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3' </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">AMARA MIMOUN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">R </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">D </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">R </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">D </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">R </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">D </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">R </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">D </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANDALOUSSI-HASSANI AHMED</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANDRENACCI SABATINO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANDRONICO FLAVIO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">CIMPN </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">CIMPN </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANTOINE RENAUD</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Chefs d'atelier / service</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BARZIN JEAN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BAUDELET JULIEN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Chefs d'atelier / service</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BELIK SANDY</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Chefs d'atelier / service</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BENAGOUNE RACHID</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BERTRAND PATRICK</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BOGAERTS PIERRE</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Expédition</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(189, 183, 107); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3' </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BONGIOVANNI FILIPPO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BOUCHER JEAN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">CIMPN </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: linear-gradient(to right, rgb(188, 143, 143) 33.33%, rgb(176, 196, 222) 33.33%, rgb(176, 196, 222) 66.66%, rgb(188, 143, 143) 66.66%); color: black;"">
                        <!----><span _ngcontent-c4="""">CIMPN </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BUFFIN FERNAND</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">CAGNINA DAMIANO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">CALABRO FABRIZIO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Expédition</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(189, 183, 107); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr>
            <tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">CANTILLON DAVID</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">1</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">1</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr>
        </tbody>
    </table><ng-busy-backdrop>
        <!---->
    </ng-busy-backdrop><ng-busy>
        <!---->
    </ng-busy>

    <!----><div _ngcontent-c4="""" class=""legend"">
        <!----><!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(238, 232, 170);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC - @ - Défaut</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(188, 143, 143);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC Prestations</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC - Repos - Défaut</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC - Dominical - Défaut</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. GREVE</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(189, 183, 107);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">C. FERIE (à date)</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(255, 255, 255);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">PREST.</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(255, 192, 203);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. AUT. PT CHOMAGE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. RAISON FAMILIALE IMPERIEUSE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. AUT. NON PAYEE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. NON AUT. NON PAYEE</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">REPOS</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">DOMINICAL wat langere naam aangeven voor test doeleinde :) :) :) :) :) :) :) :) </div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        
    </div>

    
    <!---->
";

        public const string OneWeek =@"<table _ngcontent-c4="""" class=""table table-bordered"" id=""resultsTable"">
        <thead _ngcontent-c4="""" style="""">
            <tr _ngcontent-c4="""">
                <!----><th _ngcontent-c4="""">Nom</th>
                <!----><th _ngcontent-c4="""">Département</th>
                <!---->
                <!---->
                <!---->
                <!----><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">lu</span>
                    <span _ngcontent-c4="""" class=""vertical"">19</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ma</span>
                    <span _ngcontent-c4="""" class=""vertical"">20</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">me</span>
                    <span _ngcontent-c4="""" class=""vertical"">21</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">je</span>
                    <span _ngcontent-c4="""" class=""vertical"">22</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">ve</span>
                    <span _ngcontent-c4="""" class=""vertical"">23</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">sa</span>
                    <span _ngcontent-c4="""" class=""vertical"">24</span>
                </th><th _ngcontent-c4="""" class=""dayHeader smallerPadding"">
                    <span _ngcontent-c4="""" class=""vertical"">di</span>
                    <span _ngcontent-c4="""" class=""vertical"">25</span>
                </th>
            </tr>
        </thead>
        <tbody _ngcontent-c4="""">
            <!----><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">AGOZZINO sgo (tst) FRANCES</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: linear-gradient(to right, rgb(188, 143, 143) 33.33%, rgb(176, 196, 222) 33.33%, rgb(176, 196, 222) 66.66%, rgb(188, 143, 143) 66.66%); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: linear-gradient(to right, rgb(188, 143, 143) 33.33%, rgb(255, 192, 203) 33.33%, rgb(255, 192, 203) 66.66%, rgb(188, 143, 143) 66.66%); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ALAIMO DAVID</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">AMARA AHMED</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Expédition</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">X1 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">AMARA MIMOUN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">MI700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">R </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">D </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANDALOUSSI-HASSANI AHMED</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(255, 255, 255); color: black;"">
                        <!----><span _ngcontent-c4="""">P4 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANDRENACCI SABATINO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANDRONICO FLAVIO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">ANTOINE RENAUD</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Chefs d'atelier / service</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BARZIN JEAN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BAUDELET JULIEN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Chefs d'atelier / service</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BELIK SANDY</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Chefs d'atelier / service</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BENAGOUNE RACHID</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BERTRAND PATRICK</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: transparent; color: black;"">
                        <!----><span _ngcontent-c4="""">RP700 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BOGAERTS PIERRE</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Expédition</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3' </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BONGIOVANNI FILIPPO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BOUCHER JEAN</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">BUFFIN FERNAND</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C7 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">CAGNINA DAMIANO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(238, 232, 170); color: black;"">
                        <!----><span _ngcontent-c4="""">RPC@ </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R9 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">CALABRO FABRIZIO</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Expédition</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R3 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">RE </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr><tr _ngcontent-c4="""">
                <!----><td _ngcontent-c4="""" class=""info"">CANTILLON DAVID</td>
                <!----><td _ngcontent-c4="""" class=""info"">x RPC x Rotatives</td>
                <!---->
                <!---->
                <!---->
                <!----><!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">2</span>
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">R2 </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">1</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(188, 143, 143); color: black;"">
                        <!----><span _ngcontent-c4="""">C4 </span>
                        <!---->
                        <!---->

                        <!----><span _ngcontent-c4="""" class=""indicator anomalyCounter"">1</span>
                        <!----><span _ngcontent-c4="""" class=""fa fa-clock-o timetableException""></span>
                    </td>
                <!---->
                    <td _ngcontent-c4="""" class=""smallerPadding colorCell minWidth clickable"" style=""background: rgb(192, 192, 192); color: black;"">
                        <!----><span _ngcontent-c4="""">DO </span>
                        <!---->
                        <!---->

                        <!---->
                        <!---->
                    </td>
                
            </tr>
        </tbody>
    </table><ng-busy-backdrop>
        <!---->
    </ng-busy-backdrop><ng-busy>
        <!---->
    </ng-busy>

    <!----><div _ngcontent-c4="""" class=""legend"">
        <!----><!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(188, 143, 143);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC Prestations</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC - Repos - Défaut</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC - Dominical - Défaut</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(255, 255, 255);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">PREST.</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(238, 232, 170);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">RPC - @ - Défaut</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. GREVE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(255, 192, 203);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. AUT. PT CHOMAGE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. RAISON FAMILIALE IMPERIEUSE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. AUT. NON PAYEE</div>
            </div>
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(176, 196, 222);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">ABS. NON AUT. NON PAYEE</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">REPOS</div>
            </div>
        <!---->
            <!---->
        <!---->
            <!----><div _ngcontent-c4="""" class=""legendItem"">
                <!----><div _ngcontent-c4="""" class=""legendColor"" style=""background: rgb(192, 192, 192);""></div>
                <!---->
                <div _ngcontent-c4="""" class=""legendDescription"">DOMINICAL wat langere naam aangeven voor test doeleinde :) :) :) :) :) :) :) :) </div>
            </div>
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        <!---->
            <!---->
        
    </div>

    
    <!---->
";

    }
}