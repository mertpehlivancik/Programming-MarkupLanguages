<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateIncomingsTable extends Migration
{

    public function up()
    {
        Schema::create('incomings', function (Blueprint $table) {
            $table->increments('id');
            $table->unsignedInteger('company_id')->index();
            $table->decimal('amount',10,2);
            $table->timestamps();
        });

        Schema::table('incomings', function($table) {
            $table->foreign('company_id')->references('id')->on('companies')->onDelete('cascade');
        });
    }


    public function down()
    {
        Schema::dropIfExists('incomings');
    }
}
