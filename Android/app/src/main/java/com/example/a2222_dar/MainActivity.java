package com.example.a2222_dar;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnCall.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v){
                // Code qui sera exécuté lors du clic du bouton
                String name = txtName.getText().toString();
                Log.i(TAG, “Hello “ + name);
            }
        });
    }
}