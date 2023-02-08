Public Class Editor
    Dim sm As New SettingManager(Form1.ServerLocation + "\server.properties")
    Public GeneratorSettings As String = "{}"
    Public MOTD As String = ""
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sm.GetSetting("allow-flight") = "true" Then
            Guna2CheckBox1.Checked = True
        Else
            Guna2CheckBox1.Checked = False
        End If
        If sm.GetSetting("allow-nether") = "true" Then
            Guna2CheckBox2.Checked = True
        Else
            Guna2CheckBox2.Checked = False
        End If
        If sm.GetSetting("broadcast-console-to-ops") = "true" Then
            Guna2CheckBox3.Checked = True
        Else
            Guna2CheckBox3.Checked = False
        End If
        If sm.GetSetting("broadcast-rcon-to-ops") = "true" Then
            Guna2CheckBox4.Checked = True
        Else
            Guna2CheckBox4.Checked = False
        End If
        Guna2ComboBox1.Text = sm.GetSetting("difficulty")
        If sm.GetSetting("enable-command-block") = "true" Then
            Guna2CheckBox5.Checked = True
        Else
            Guna2CheckBox5.Checked = False
        End If
        If sm.GetSetting("enable-jmx-monitoring") = "true" Then
            Guna2CheckBox6.Checked = True
        Else
            Guna2CheckBox6.Checked = False
        End If
        If sm.GetSetting("enable-query") = "true" Then
            Guna2CheckBox7.Checked = True
        Else
            Guna2CheckBox7.Checked = False
        End If
        If sm.GetSetting("enable-rcon") = "true" Then
            Guna2CheckBox8.Checked = True
        Else
            Guna2CheckBox8.Checked = False
        End If
        If sm.GetSetting("enable-status") = "true" Then
            Guna2CheckBox9.Checked = True
        Else
            Guna2CheckBox9.Checked = False
        End If
        If sm.GetSetting("enforce-whitelist") = "true" Then
            Guna2CheckBox10.Checked = True
        Else
            Guna2CheckBox10.Checked = False
        End If
        Guna2TextBox1.Text = sm.GetSetting("entity-broadcast-range-percentage")
        If sm.GetSetting("force-gamemode") = "true" Then
            Guna2CheckBox11.Checked = True
        Else
            Guna2CheckBox11.Checked = False
        End If
        Guna2TextBox2.Text = sm.GetSetting("function-permission-level")
        Guna2ComboBox2.Text = sm.GetSetting("gamemode")
        If sm.GetSetting("generate-structures") = "true" Then
            Guna2CheckBox12.Checked = True
        Else
            Guna2CheckBox12.Checked = False
        End If
        GeneratorSettings = sm.GetSetting("generator-settings")
        If sm.GetSetting("hardcore") = "true" Then
            Guna2CheckBox13.Checked = True
        Else
            Guna2CheckBox13.Checked = False
        End If
        If sm.GetSetting("hide-online-players") = "true" Then
            Guna2CheckBox14.Checked = True
        Else
            Guna2CheckBox14.Checked = False
        End If
        Guna2TextBox3.Text = sm.GetSetting("level-name")
        Guna2TextBox4.Text = sm.GetSetting("level-seed")
        Guna2ComboBox3.Text = sm.GetSetting("level-type")
        Guna2TextBox5.Text = sm.GetSetting("max-players")
        Guna2TextBox6.Text = sm.GetSetting("max-tick-time")
        Guna2TextBox7.Text = sm.GetSetting("max-world-size")
        MOTD = sm.GetSetting("motd")
        Guna2TextBox8.Text = sm.GetSetting("network-compression-threshold")
        If sm.GetSetting("online-mode") = "true" Then
            Guna2CheckBox15.Checked = False
        Else
            Guna2CheckBox15.Checked = True
        End If
        Guna2TextBox9.Text = sm.GetSetting("op-permission-level")
        Guna2TextBox10.Text = sm.GetSetting("player-idle-timeout")
        If sm.GetSetting("prevent-proxy-connections") = "true" Then
            Guna2CheckBox16.Checked = True
        Else
            Guna2CheckBox16.Checked = False
        End If
        If sm.GetSetting("pvp") = "true" Then
            Guna2CheckBox17.Checked = True
        Else
            Guna2CheckBox17.Checked = False
        End If
        Guna2TextBox11.Text = sm.GetSetting("query.port")
        Guna2TextBox12.Text = sm.GetSetting("rate-limit")
        Guna2TextBox13.Text = sm.GetSetting("rcon.password")
        Guna2TextBox14.Text = sm.GetSetting("rcon.port")
        If sm.GetSetting("require-resource-pack") = "true" Then
            Guna2CheckBox18.Checked = True
        Else
            Guna2CheckBox18.Checked = False
        End If
        Guna2TextBox15.Text = sm.GetSetting("resource-pack")
        Guna2TextBox16.Text = sm.GetSetting("resource-pack-prompt")
        Guna2TextBox17.Text = sm.GetSetting("resource-pack-sha1")
        Guna2TextBox18.Text = sm.GetSetting("server-ip")
        Guna2TextBox19.Text = sm.GetSetting("server-port")
        Guna2TextBox20.Text = sm.GetSetting("simulation-distance")
        If sm.GetSetting("spawn-animals") = "true" Then
            Guna2CheckBox19.Checked = True
        Else
            Guna2CheckBox19.Checked = False
        End If
        If sm.GetSetting("spawn-monsters") = "true" Then
            Guna2CheckBox20.Checked = True
        Else
            Guna2CheckBox20.Checked = False
        End If
        If sm.GetSetting("spawn-npcs") = "true" Then
            Guna2CheckBox21.Checked = True
        Else
            Guna2CheckBox21.Checked = False
        End If
        Guna2TextBox21.Text = sm.GetSetting("spawn-protection")
        If sm.GetSetting("sync-chunk-writes") = "true" Then
            Guna2CheckBox22.Checked = True
        Else
            Guna2CheckBox22.Checked = False
        End If
        Guna2TextBox22.Text = sm.GetSetting("text-filtering-config")
        If sm.GetSetting("use-native-transport") = "true" Then
            Guna2CheckBox23.Checked = True
        Else
            Guna2CheckBox23.Checked = False
        End If
        Guna2TextBox23.Text = sm.GetSetting("view-distance")
        If sm.GetSetting("white-list") = "true" Then
            Guna2CheckBox24.Checked = True
        Else
            Guna2CheckBox24.Checked = False
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        input.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        motd_editor.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            ' Section 1
            sm.AddSetting("allow-flight", Guna2CheckBox1.Checked.ToString.ToLower)
            sm.AddSetting("allow-nether", Guna2CheckBox2.Checked.ToString.ToLower)
            sm.AddSetting("broadcast-console-to-ops", Guna2CheckBox3.Checked.ToString.ToLower)
            sm.AddSetting("broadcast-rcon-to-ops", Guna2CheckBox4.Checked.ToString.ToLower)
            sm.AddSetting("difficulty", Guna2ComboBox1.Text)
            sm.AddSetting("enable-command-block", Guna2CheckBox5.Checked.ToString.ToLower)
            sm.AddSetting("enable-jmx-monitoring", Guna2CheckBox6.Checked.ToString.ToLower)
            sm.AddSetting("enable-query", Guna2CheckBox7.Checked.ToString.ToLower)
            sm.AddSetting("enable-rcon", Guna2CheckBox8.Checked.ToString.ToLower)
            sm.AddSetting("enable-status", Guna2CheckBox9.Checked.ToString.ToLower)
            sm.AddSetting("enforce-whitelist", Guna2CheckBox10.Checked.ToString.ToLower)
            sm.AddSetting("entity-broadcast-range-percentage", Guna2TextBox1.Text)
            sm.AddSetting("force-gamemode", Guna2CheckBox11.Checked.ToString.ToLower)
            sm.AddSetting("function-permission-level", Guna2TextBox2.Text)
            sm.AddSetting("gamemode", Guna2ComboBox2.Text)
            ' Section 2
            sm.AddSetting("generate-structures", Guna2CheckBox12.Checked.ToString.ToLower)
            sm.AddSetting("generator-settings", GeneratorSettings.ToString.ToLower)
            sm.AddSetting("hardcore", Guna2CheckBox13.Checked.ToString.ToLower)
            sm.AddSetting("hide-online-players", Guna2CheckBox14.Checked.ToString.ToLower)
            sm.AddSetting("level-name", Guna2TextBox3.Text)
            sm.AddSetting("level-seed", Guna2TextBox4.Text)
            sm.AddSetting("level-type", Guna2ComboBox3.Text.ToString.ToLower)
            sm.AddSetting("max-players", Guna2TextBox5.Text)
            sm.AddSetting("max-tick-time", Guna2TextBox6.Text)
            sm.AddSetting("max-world-size", Guna2TextBox7.Text)
            sm.AddSetting("motd", MOTD.ToString)
            sm.AddSetting("network-compression-threshold", Guna2TextBox8.Text)
            sm.AddSetting("online-mode", Guna2CheckBox15.Checked.ToString.ToLower)
            sm.AddSetting("op-permission-level", Guna2TextBox9.Text)
            sm.AddSetting("player-idle-timeout", Guna2TextBox10.Text)
            sm.AddSetting("prevent-proxy-connections", Guna2CheckBox16.Checked.ToString.ToLower)
            sm.AddSetting("pvp", Guna2CheckBox17.Checked.ToString.ToLower)
            sm.AddSetting("query.port", Guna2TextBox11.Text)
            sm.AddSetting("rate-limit", Guna2TextBox12.Text)
            sm.AddSetting("rcon.password", Guna2TextBox13.Text)
            sm.AddSetting("rcon.port", Guna2TextBox14.Text)
            sm.AddSetting("require-resource-pack", Guna2CheckBox18.Checked.ToString.ToLower)
            sm.AddSetting("resource-pack", Guna2TextBox15.Text)
            sm.AddSetting("resource-pack-prompt", Guna2TextBox16.Text)
            sm.AddSetting("resource-pack-sha1", Guna2TextBox17.Text)
            sm.AddSetting("server-ip", Guna2TextBox18.Text)
            sm.AddSetting("server-port", Guna2TextBox19.Text)
            sm.AddSetting("simulation-distance", Guna2TextBox20.Text)
            sm.AddSetting("spawn-animals", Guna2CheckBox19.Checked.ToString.ToLower)
            ' Section 3
            sm.AddSetting("spawn-monsters", Guna2CheckBox20.Checked.ToString.ToLower)
            sm.AddSetting("spawn-npcs", Guna2CheckBox21.Checked.ToString.ToLower)
            sm.AddSetting("spawn-protection", Guna2TextBox21.Text)
            sm.AddSetting("sync-chunk-writes", Guna2CheckBox22.Checked.ToString.ToLower)
            sm.AddSetting("text-filtering-config", Guna2TextBox22.Text)
            sm.AddSetting("use-native-transport", Guna2CheckBox23.Checked.ToString.ToLower)
            sm.AddSetting("view-distance", Guna2TextBox23.Text)
            sm.AddSetting("white-list", Guna2CheckBox24.Checked.ToString.ToLower)
            sm.Save()
            Me.Close()
        Catch ex As Exception
            Me.Hide()
            Form1.ErrorContent = ex.ToString
            Form1.Guna2Transition1.ShowSync(Form1.Guna2Chip1)
        End Try
    End Sub
End Class