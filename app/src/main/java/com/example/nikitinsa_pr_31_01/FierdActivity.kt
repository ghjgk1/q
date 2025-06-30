package com.example.nikitinsa_pr_31_01

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import com.example.nikitinsa_pr_31_01.R

class FierdActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_fierd)
        val image = findViewById<ImageView>(R.id.logo)

        val r = intent.getDoubleExtra("r", 0.0)
        val a = intent.getDoubleExtra("a", 0.0)
        val b = intent.getDoubleExtra("b", 0.0)
        val с = intent.getDoubleExtra("с", 0.0)
        val shape = intent.getStringExtra("shape")
        val button = findViewById<Button>(R.id.button)
        val passwordText=findViewById<EditText>(R.id.password)
        val loginText=findViewById<EditText>(R.id.login)

        loginText.setText(shape)
        var rez = r * (2 * 3.14)
        if (shape == "Треугольник") {
            image.setImageResource(R.drawable.vubor2)
            rez = 2 * a + b
        }
        if (shape == "Круг") image.setImageResource(R.drawable.vubor1)
        passwordText.setText(String.format("%.3f", rez))

        button.setOnClickListener {
            var intent: Intent
            intent= Intent(this, FirstActivity::class.java)
            startActivity(intent)

        }
    }
}