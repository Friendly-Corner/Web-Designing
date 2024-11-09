import './Butik.css';

function Butik() {

    return(
        <>
        <div className="wrapper">
            <div className='section-3 section' id='butik'>
                <div className='butik-bgd-img'></div>
            </div>
                <div className="butik-sub sub" >
                    <div className='butik-text text'>
                        <h1>Butik</h1><br />
                        <p>Inredning, barnböcker och mycket annat.</p><br />
                        <p>I vår butik, på mysiga Tändsticksområdet, hittar du inredning, barnböcker och
                            mycket annat.</p>
                        <p>Vi försöker hitta det unika och speciella till dig!</p>
                        <br />
                        <p> Mycket av det vi säljer är producerat i vårt närområde.</p>
                        <p>Åsa som är inredare och stylist hittar de trendiga inredningsdetaljerna och Tinna illustrerar unika kort,
                            posters och böcker för barn.</p>
                        <br />
                        <p>Varmt välkommen in.</p>
                    </div>
                </div>
            <dic className="butik-cont">
                <div className="insta-sub">
                    <div className="instagram-embed">
                        <iframe async
                            src="https://www.instagram.com/tinnadesign/embed"
                            allowtransparency="true"
                        ></iframe>
                    </div>
                </div>
            </dic>
        </div>
        </>
    );
}

export default Butik;