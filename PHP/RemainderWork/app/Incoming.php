<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Incoming extends Model
{
    protected $fillable = [
        'company_id',
        'amount'
    ];

    public function company(){
        return $this->belongsTo('App\Company');
    }
}
