<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
    <head>
      <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
      <script type="text/javascript" src="../../assets/vue/vue.min.js"></script>
    </head>
    <body style="margin:0; padding:0; background-color:#F2F2F2;" data-gr-c-s-loaded="true">
      <div id="emailTemplate" style="width: 100%;">
        <table width="100%" align="center" border="0" cellpadding="0" cellspacing="0">
          <tbody>
            <tr>
              <td height="40"></td>
            </tr>
            <tr>
              <td>
                <table width="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#F2F2F2" style="margin-top: 0px;">
                  <tbody>
                    <tr>
                      <td align="center" valign="top">
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" class="wrapper" style="background-color: rgb(255, 255, 255);">
                          <tbody>
                            <tr>
                              <td height="20"></td>
                            </tr>
                            <tr>
                              <td align="center" valign="top">
                                <table width="600" cellpadding="0" cellspacing="0" border="0" class="container">
                                  <tbody>
                                    <tr>
                                      <td align="center" valign="top">
                                        <img src="{{imgLogo}}" alt="logo" height="auto" width="100" style="padding: 5px;"/>
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                            <tr>
                              <td height="10"></td>
                            </tr>
                            <tr>
                              <td style="font-family: Poppins, sans-serif; text-align: center; font-size: 16px; color: rgb(102, 102, 102); text-transform: uppercase;">{{emailTitle}}</td>
                            </tr>
                            <tr style="border-bottom: 1px solid rgb(204, 204, 204);">
                              <td height="20"></td>
                            </tr>
                          </tbody>
                        </table>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </td>
            </tr>
            <tr>
              <td>
                <table width="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#F2F2F2">
                  <tbody>
                    <tr>
                      <td align="center" valign="top">
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" class="wrapper">
                          <tbody>
                            <tr>
                              <td align="center" valign="top">
                                <table width="600" cellpadding="0" cellspacing="0" border="0" class="container" style="margin-top: 20px;">
                                  <tbody>
                                    <tr>
                                      <td align="center" valign="top" style="height: auto;">
                                        <img src="{{imgBg}}" style="width: 200px;"/>
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                          </tbody>
                        </table>
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" class="wrapper">
                          <tbody>
                            <tr>
                              <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                            </tr>
                            <tr>
                              <td align="center" valign="top">
                                <table width="600" cellpadding="0" cellspacing="0" border="0" class="container">
                                  <tbody>
                                    <tr>
                                      <td align="center" valign="top" color="#F2F2F2" width="400">
										  <table width="400" align="center">
											<tr>
												<td align="center">
													<h1 style="color: rgb(68, 184, 157); font-family: Poppins, sans-serif; margin-bottom: 7px; font-weight: 600; margin-top: 0px; font-size: 25px; letter-spacing: 1px;">{{greeting}}</h1>
													<h2 style="color: rgb(68, 184, 157); font-family: Poppins, sans-serif; margin-bottom: 7px; font-weight: 500; margin-top: 0px; font-size: 22px;">{{greetBody}}</h2>
													<p style="color: rgb(102, 102, 102); font-family: Poppins, sans-serif; margin-top: 0px; margin-bottom: 20px;"></p>
												</td>
											</tr>
										</table>
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                            <tr>
                              <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                            </tr>
                          </tbody>
                        </table>
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" class="wrapper">
                          <tbody>
                            <tr>
                              <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                            </tr>
                            <tr>
                              <td align="center" valign="top">
                                <table cellpadding="0" cellspacing="0" border="0" class="container">
                                  <tbody>
                                    <tr>
                                      <td align="center" valign="top" class="mobileOn mobile" style="font-family: Poppins, sans-serif;">{mainContent}</td>
                                    </tr>
                                    <tr>
                                      <td height="20"></td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                            <tr>
                              <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                            </tr>
                          </tbody>
                        </table>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </td>
            </tr>
            <tr>
              <td>
                <table width="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#F2F2F2">
                  <tbody>
                    <tr>
                      <td align="center" valign="top">
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" class="wrapper">
                          <tbody>
                            <tr>
                              <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                            </tr>
                          </tbody>
                        </table>
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" class="wrapper" style="{{showBtn}}">
                          <tbody>
                            <tr>
                              <td height="10" style="font-size: 14px; line-height: 30px; text-align: center; font-family: arial; color: rgb(40, 40, 40);">Please login to review</td>
                            </tr>
                            <tr>
                              <td align="center" valign="top">
                                <table width="600" cellpadding="0" cellspacing="0" border="0" class="container">
                                  <tbody>
                                    <tr>
                                      <td align="center" valign="top" color="#F2F2F2">
                                        <table width="100%" cellpadding="0" cellspacing="0" border="0">
                                          <tr>
                                            <td width="200"></td>
                                            <td align="center" width="400">
                                              <a href="{{linkBtn}}">
                                                <div style="background: rgb(247, 167, 3);padding: 10px;color: rgb(255, 255, 255);text-align: center;border-radius: 5px;font-family: Poppins, sans-serif;max-width: 200px;font-size: 20px;font-weight: 600;box-shadow: rgba(114, 120, 141, 0.2) 0px 8px 15px;cursor: pointer;outline: none;text-decoration: none;display: block;">login</div>
                                              </a>
                                            </td>
                                            <td width="200"></td>
                                          </tr>
                                        </table>                                        
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                            <tr>
                              <td height="25" style="font-size: 10px; line-height: 10px;"></td>
                            </tr>
                          </tbody>
                        </table>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </td>
            </tr>
            <tr>
              <td>
                <table width="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#F2F2F2">
                  <tbody>
                    <tr>
                      <td align="center" valign="top">
                        <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="" class="wrapper" style="background-color: rgb(204, 204, 204);">
                          <tbody>
                            <tr>
                              <td align="center" valign="top">
                                <table>
                                  <tbody>
                                    <tr>
                                      <td>
                                        <table width="100%" cellpadding="0" cellspacing="0" border="0" bgcolor="#cccccc" class="wrapper">
                                          <tbody>
                                            <tr>
                                              <td align="center" valign="top">
                                                <table width="640" cellpadding="0" cellspacing="0" border="0" bgcolor="#ffffff" style="background-color: rgb(228, 228, 228);">
                                                  <tbody>
                                                    <tr>
                                                      <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                                                    </tr>
                                                    <tr>
                                                      <td align="center" valign="top">
                                                        <table width="600" cellpadding="0" cellspacing="0" border="0">
                                                          <tbody>
                                                            <tr>
                                                              <td align="center" valign="top" color="#F2F2F2">
                                                                <p style="color: rgb(94, 94, 94); font-family: arial, sans-serif; max-width: 400px; font-size: 14px; font-weight: 400;"> Please do not reply to this email. Emails sent to this address will not be answered. </p>
                                                              </td>
                                                            </tr>
                                                          </tbody>
                                                        </table>
                                                      </td>
                                                    </tr>
                                                    <tr>
                                                      <td height="10" style="font-size: 10px; line-height: 10px;"></td>
                                                    </tr>
                                                  </tbody>
                                                </table>
                                                <table width="600" cellpadding="0" cellspacing="0" border="0" class="container">
                                                  <tbody>
                                                    <tr>
                                                      <td align="center" valign="top">
                                                        <div style="width:100%; padding-top: 10px;">
                                                          <span style="color: rgb(22, 22, 22); font-size: 14px; font-family: Poppins, sans-serif; font-weight: 600;">{contactDepartmentName}</span>
                                                          <div style="height: 10px;"></div>
                                                          <div style="color: rgb(22, 22, 22); font-size: 12px; font-family: Poppins, sans-serif;">{contactDepartmentAddress}</div>
                                                        </div>
                                                        <div style="height: 20px;"></div>
                                                      </td>
                                                    </tr>
                                                  </tbody>
                                                </table>
                                              </td>
                                            </tr>
                                          </tbody>
                                        </table>
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                            <tr></tr>
                          </tbody>
                        </table>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </body>
  </html>
  </xsl:template>
</xsl:stylesheet>