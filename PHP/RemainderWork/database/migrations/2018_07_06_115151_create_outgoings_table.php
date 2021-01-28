<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateOutgoingsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('outgoings', function (Blueprint $table) {
            $table->increments('id');
            $table->unsignedInteger('company_id')->index();
            $table->decimal('amount',10,2);
            $table->timestamps();
        });
        Schema::table('outgoings', function($table) {
            $table->foreign('company_id')->references('id')->on('companies')->onDelete('cascade');
        });
    }




    public function down()
    {
        Schema::dropIfExists('outgoings');
    }
}
