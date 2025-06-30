package com.example.nikitinsa_pr_31_01

import android.annotation.SuppressLint
import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.AdapterView
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import android.widget.Spinner
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity

class SecondActivity : AppCompatActivity() {
    @SuppressLint("MissingInflatedId")

    open fun isDouble(strNum: String): Boolean {
        try {
            val d = strNum.toDouble()
        } catch (nfe: NumberFormatException) {
            return false
        } catch (nfe: NullPointerException) {
            return false
        }
        return true
    }
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second)
        val spinner = findViewById<Spinner>(R.id.spinner)
        val image = findViewById<ImageView>(R.id.image)
        val button=findViewById<Button>(R.id.button)
        val data1 = findViewById<EditText>(R.id.data1)
        val data2 = findViewById<EditText>(R.id.data2)

        spinner.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(
                parent: AdapterView<*>?,
                view: View,
                position: Int,
                id: Long
            ) {
                when (position) {
                    0 -> {
                        image.setImageResource(R.drawable.vubor2)
                        data2.visibility = View.VISIBLE
                        data1.hint = "Введите a"
                        data2.hint = "Введите b"
                    }
                    1 -> {
                        image.setImageResource(R.drawable.vubor1)
                        data2.visibility = View.GONE
                        data1.hint = "Введите радиус"
                    }
                }
            }

            override fun onNothingSelected(parent: AdapterView<*>?) {
            }
        }

        button.setOnClickListener {
            val intent = Intent(this, FierdActivity::class.java)
            val selected = spinner.selectedItem

            if (selected == "Круг"){
                if (data1.text.toString().toDoubleOrNull() == null ){
                    var alertDialog= AlertDialog.Builder(this)
                    alertDialog
                        .setMessage("Не верные данные!")
                        .setPositiveButton("ОК") {
                                dialog, id ->  dialog.cancel()
                        }
                    alertDialog.create()
                    alertDialog.show()
                }
                else if(data1.text.toString() == "")
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
                else if (data1.text.toString().toDouble() > 0)
                {
                    val znach = data1.getText().toString()
                    intent.putExtra("r", znach.toDouble());
                    intent.putExtra("shape", "Круг")
                    startActivity(intent)
                }
                else {
                    var alertDialog= AlertDialog.Builder(this)
                    alertDialog
                        .setMessage("Не верные данные!")
                        .setPositiveButton("ОК") {
                                dialog, id ->  dialog.cancel()
                        }
                    alertDialog.create()
                    alertDialog.show()
                }
            }
            else {
                if (data1.text.toString().toDoubleOrNull() == null || data2.text.toString().toDoubleOrNull() == null){
                    var alertDialog= AlertDialog.Builder(this)
                    alertDialog
                        .setMessage("Не верные данные!")
                        .setPositiveButton("ОК") {
                                dialog, id ->  dialog.cancel()
                        }
                    alertDialog.create()
                    alertDialog.show()
                }
                else if(data1.text.toString() == "" || data2.text.toString() == "")
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
                else if (data1.text.toString().toDouble() > 0 && data2.text.toString().toDouble() > 0)
                {
                    val a = data2.getText().toString().toDouble()
                    val b = data1.getText().toString().toDouble()
                    if (a + a > b && a + b > a){
                        intent.putExtra("a", b)
                        intent.putExtra("b", a)
                        intent.putExtra("shape", "Треугольник")
                        startActivity(intent)
                    }
                    else {
                        var alertDialog= AlertDialog.Builder(this)
                        alertDialog
                            .setMessage("Не существует такого треугольника!")
                            .setPositiveButton("ОК") {
                                    dialog, id ->  dialog.cancel()
                            }
                        alertDialog.create()
                        alertDialog.show()
                    }
                }
                else{
                    var alertDialog= AlertDialog.Builder(this)
                    alertDialog
                        .setMessage("Не верные данные!")
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