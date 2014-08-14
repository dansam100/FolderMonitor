<?xml version="1.0" encoding="ISO-8859-1" ?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
	<xsl:template match="/">
		<html xsl:version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="http://www.w3.org/1999/xhtml">
			<body style="font-family:Arial;font-size:12pt;background-color:#EEEEEE">
				<table border="1">
					<tr style="background-color:blue;color:white;font-family:Comic Sans MS">
						<th cellpadding="2">Monitee</th>
						<th cellpadding="2">Destination</th>
						<th cellpadding="2">Type</th>
					</tr>
					<xsl:for-each select="FolderMonitor/Monitee">
						<span id="rows">
							<tr style="background-color:white;color:blue;font-family:Calibri">
								<td>
									<span style="cursor:hand">
										<xsl:value-of select="Source" /> 
									</span>
								</td>
								<td>
									<span style="cursor:hand">
										<xsl:value-of select="Destination" />
									</span>
								</td>
								<td>
									<span style="cursor:hand">
										<xsl:value-of select="Type" />
									</span>
								</td>
							</tr>
						</span>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>