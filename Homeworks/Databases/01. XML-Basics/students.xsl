<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:myStudents="urn:students">
<xsl:template match="/">
<html>
<head>
    <title>Students List</title>
    <link rel="stylesheet" href="./style/style.css"/>
</head>
<body>
    <header>
        <h1>Students List</h1>        
    </header>
    <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Sex</th>
                    <th>Birth Date</th>
                    <th>Phone</th>
                    <th>E-mail</th>
                    <th>Course</th>
                    <th>Speciality</th>
                    <th>Faculty</th>
                    <th>Passed Exams</th>
                </tr>
            </thead>
            <tbody>
                <xsl:for-each select="myStudents:students/myStudents:student">
                    <tr>
                        <td><xsl:value-of select="myStudents:name"/></td>
                        <td><xsl:value-of select="myStudents:sex"/></td>
                        <td><xsl:value-of select="myStudents:birthDate"/></td>
                        <td><xsl:value-of select="myStudents:phone"/></td>
                        <td><xsl:value-of select="myStudents:email"/></td>
                        <td><xsl:value-of select="myStudents:course"/></td>
                        <td><xsl:value-of select="myStudents:speciality"/></td>
                        <td><xsl:value-of select="myStudents:faculty"/></td>
                        <td>
                            <xsl:for-each select="myStudents:exams/myStudents:exam">
                                <div>
                                    <span>
                                        <xsl:value-of select="myStudents:examName"/> 
                                    </span>
                                    <span id="tutor">
                                        (tutor: <xsl:value-of select="myStudents:tutor"/>)
                                    </span>
                                    <span id="score">
                                        <xsl:value-of select="myStudents:score"/>
                                    </span>
                                </div>
                            </xsl:for-each>
                        </td>
                    </tr>
                </xsl:for-each>
            </tbody> 
        </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>