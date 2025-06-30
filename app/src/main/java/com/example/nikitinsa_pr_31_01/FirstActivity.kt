package com.example.nikitinsa_pr_31_01

import android.content.Intent
import android.content.SharedPreferences
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import androidx.appcompat.app.AlertDialog

class FirstActivity : AppCompatActivity() {
    lateinit var passwordText: EditText
    lateinit var loginText: EditText
    lateinit var button: Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_first)

        passwordText=findViewById(R.id.password)
        loginText=findViewById(R.id.login)
        button=findViewById(R.id.button)

        button.setOnClickListener {
            var sh: SharedPreferences =getSharedPreferences("PreferencesName",MODE_PRIVATE)
            var loginSave:String = sh.getString("login","").toString()
            var passwordSave:String = sh.getString("password","").toString()


            var loginInput : String = loginText.text.toString()
            var passwordInput : String = passwordText.text.toString()

            if(loginInput == "" || passwordInput =="")
            {
                var alertDialog= AlertDialog.Builder(this)
                alertDialog
                    .setMessage("Пустые поля!")
                    .setPositiveButton("ОК") {
                            dialog, id ->  dialog.cancel()
                    }
                alertDialog.create()
                alertDialog.show()
            }
            else
            {
                if(loginSave=="" || passwordSave=="")
                {
                    if(loginInput == "ects" &&  passwordInput =="ects2024")
                    {
                        var editor=sh.edit()
                        editor.putString("login", loginInput)
                        editor.putString("password", passwordInput)
                        editor.apply()
                        var intent: Intent
                        intent= Intent(this, SecondActivity::class.java)
                        startActivity(intent)
                    }
                    else {
                        var alertDialog= AlertDialog.Builder(this)
                        alertDialog
                            .setMessage("Логин: ects Пароль: ects2024")
                            .setPositiveButton("ОК") {
                                    dialog, id ->  dialog.cancel()
                            }
                        alertDialog.create()
                        alertDialog.show()
                    }
                }
                else
                {
                    if(loginSave=="ects" && passwordSave=="ects2024")
                    {
                        var intent: Intent
                        intent= Intent(this, SecondActivity::class.java)
                        startActivity(intent)
                    }
                    else
                    {
                        var alertDialog= AlertDialog.Builder(this)
                        alertDialog
                            .setMessage("Неправильный логин или/и пароль!")
                            .setPositiveButton("ОК") {
                                    dialog, id ->  dialog.cancel()
                            }
                        alertDialog.create()
                        alertDialog.show()
                    }
                }
            }
        }
    }
}