<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<head>
    <title>Music Albums</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <header>
        <h1>Music Albums</h1>        
    </header>
    <ul>
        <xsl:for-each select="catalog/album">
            <li class="title">
                <span>
                    <xsl:value-of select="artist"/> - 
                    <xsl:value-of select="name"/> 
                    (<xsl:value-of select="year"/>) - 
                    $ <xsl:value-of select="price"/>
                </span> 
                <ul class="songs">
                    <xsl:for-each select="songs/song">
                        <li>
                            <xsl:value-of select="title"/> - 
                            <xsl:value-of select="duration"/> seconds
                        </li>
                    </xsl:for-each>
                </ul>
            </li>
            <hr />
        </xsl:for-each>
    </ul>        
</body>
</html>
</xsl:template>
</xsl:stylesheet>