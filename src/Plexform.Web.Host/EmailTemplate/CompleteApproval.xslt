<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Email</title>
    </head>
    <body style="background-color:#434343;">
        <table width="100%" align="center">
            <tr>
                <td width="100%" align="center">
                    <table width="600" border="0" align="center" cellpadding="0" cellspacing="0" style="font-family:Arial,Helvetica,sans-serif;background-color:#fff;">
                        <tr>
                            <td width="25"></td>
                            <td id="headingSection" align="center" width="550">
                                <table  align="center">
                                    <tr><td height="30"></td></tr>
                                    <tr><td  align="center"><img src="http://218.208.21.89//eServicePublish/EmailTemplate/cenviro.png" style="width:130px"/></td></tr>
                                    <tr><td height="10"></td></tr>
                                    <tr><td style="font-family:Arial,Helvetica,sans-serif;">OVERRIDE TREATMENT AND HANDLING METHOD</td></tr>
                                    <tr><td height="10"></td></tr>
                                </table>
                            </td>
                            <td width="25"></td>
                        </tr>
                        <tr><td colspan="3" height="1" width="100%" style="background-color:#ccc"></td></tr>
                        <tr>
                            <td width="25"></td>
                            <td id="iconSection" width="550" align="center">
                                <table align="center" cellpadding="0" cellspacing="0">
                                    <tr><td height="10"></td></tr>
                                    <tr><td align="center"><img src="http://218.208.21.89//eServicePublish/EmailTemplate/emailApprove.png" width="300"/></td></tr>
                                    <tr><td height="30"></td></tr>
                                    <tr>
                                        <td>
                                        <table align="center" cellspacing="0" cellpadding="0" width="500">
                                        <tr>
                                            <td style="color: rgb(68, 184, 157);font-family: arial;margin-bottom: 7px;font-weight: 600; margin-top: 0;font-size: 24px;text-align: center;">
                                                Congratulation,
                                            </td>
                                        </tr>
                                        <tr><td height="10"></td></tr>
                                        <tr>
                                            <td style="color: rgb(68, 184, 157);font-family: arial;margin-bottom: 7px;font-weight: 500; margin-top: 0;font-size: 22px;text-align: center;">
                                                The following approval request is complete
                                            </td>
                                        </tr>
                                        </table>
                                        </td>
                                    </tr>
                                    <tr><td height="30"></td></tr>
                                </table>
                            </td>
                            <td width="25"></td>
                        </tr>
                        <tr>
                            <td width="100"></td>
                            <td id="contentSection" width="500" align="center">                             	
                                {emailContent}
                            </td>
                            <td width="100"></td>
                        </tr>
                        <tr><td colspan="3" height="10"></td></tr>
                         <tr>
                            <td width="100"></td>
                            <td width="500" align="center">
                                {supportContent}
                            </td>
                            <td width="100"></td>
                        </tr>
                        <tr><td colspan="3" height="12"></td></tr>

                        <tr>
                            <td width="100"></td>
                            <td id="footerSection"  width="500">
                                <table width="100%" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" align="center" border="0" bgcolor="#ffffff" style="background-color:#e4e4e4">
                                                <tbody>
                                                <tr>
                                                    <td height="10" style="font-size:10px;line-height:10px"> </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" valign="top">
                                                        <table width="600" cellpadding="0" cellspacing="0" border="0">
                                                            <tbody>
                                                            <tr>
                                                                <td align="center" valign="top" color="#F2F2F2">
                                                                    <p style="color:#5e5e5e;font-family:'arial',sans-serif;max-width:400px;font-size:14px;font-weight:400"> Please do not reply to this email. Emails sent to this address will not be answered. </p>
                                                                </td>
                                                            </tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10" style="font-size:10px;line-height:10px"> </td>
                                                </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" align="center" border="0" bgcolor="#ffffff" style="background-color:#ccc">
                                                <tbody>
                                                <tr>
                                                    <td height="10" style="font-size:10px;line-height:10px"> </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" valign="top">
                                                        <table width="600" cellpadding="0" cellspacing="0" border="0">
                                                            <tbody>
                                                            <tr><td height="15"></td></tr>
                                                            <tr>
                                                                <td align="center" style="font-size:15px;font-weight:600">
                                                                    <p>Kualiti Alam Waste Management Centre</p>
                                                                </td>
                                                            </tr>
                                                            <tr><td height="10"></td></tr>
                                                            <tr>
                                                                <td align="center" valign="top" color="#F2F2F2">
                                                                    <p style="color:#5e5e5e;font-family:'arial',sans-serif;max-width:400px;font-size:14px;font-weight:400"> Ladang Tanah Merah A3 Division, 71960 Bukit Pelandok
                                                                        P.O.Box 126, 71000 Port Dickson, Negeri Sembilan, Malaysia</p>
                                                                </td>
                                                            </tr>
                                                            <tr><td height="15"></td></tr>
                                                            </tbody>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td height="10" style="font-size:10px;line-height:10px"> </td>
                                                </tr>
                                                </tbody>
                                            </table>
                                        </td>                                       
                                    </tr>
                                </table>
                            </td>
                            <td width="100"></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </body>
</html>
</xsl:template>
</xsl:stylesheet>